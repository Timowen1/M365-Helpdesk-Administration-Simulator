using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M365_HelpDesk_Administration_Simulator.Models
{
    // Lifecycle states for simulated managed devices.
    public enum DeviceStatus
    {
        Active,
        Retired,
        Lost,
        NonCompliant
    }

    // Represents a simulated Windows device in the fake tenant.
    // Devices can be assigned to users, retired, marked lost, marked non-compliant,
    // and evaluated for simple Windows health conditions.
    public class Device
    {
        // Internal unique device identifier.
        public Guid Id { get; set; } = Guid.NewGuid();

        // Human-readable device name such as LAPTOP-SARAH01.
        public string DeviceName { get; set; }

        // Device category such as Laptop, Desktop, Tablet, or Phone.
        public string DeviceType { get; set; }

        // User ID that currently owns this device, or null if unassigned.
        public Guid? AssignedUserId { get; set; }

        // High-level lifecycle/compliance state of the device.
        public DeviceStatus Status { get; set; } = DeviceStatus.Active;

        // Simulated operating system for the device.
        public string OperatingSystem { get; set; } = "Windows 11";

        // When the device was added to the simulated inventory.
        public DateTime EnrolledAt { get; set; } = DateTime.Now;

        // Text shown in combo boxes and inventory selectors.
        public string DisplayLabel => $"{DeviceName} | {DeviceType} | {Status}";

        // Whether simulated BitLocker encryption is enabled.
        public bool BitLockerEnabled { get; set; } = true;

        // Whether simulated Windows updates are pending.
        public bool WindowsUpdatePending { get; set; } = false;

        // Whether simulated Microsoft Defender is enabled.
        public bool DefenderEnabled { get; set; } = true;

        // Whether temporary local admin access is currently granted.
        public bool LocalAdminGranted { get; set; } = false;

        // Simulated free disk space percentage.
        public int DiskSpaceFreePercent { get; set; } = 45;

        // Number of days since the device last checked in.
        public int DaysSinceLastCheckIn { get; set; } = 1;

        // Calculated summary of the most important current device health issue.
        public string DeviceHealthStatus
        {
            get
            {
                if (Status == DeviceStatus.Lost)
                    return "Lost";

                if (Status == DeviceStatus.Retired)
                    return "Retired";

                if (!DefenderEnabled)
                    return "Defender Disabled";

                if (!BitLockerEnabled)
                    return "BitLocker Disabled";

                if (WindowsUpdatePending)
                    return "Updates Pending";

                if (DiskSpaceFreePercent < 15)
                    return "Low Disk Space";

                if (DaysSinceLastCheckIn > 7)
                    return "Check-In Stale";

                if (Status == DeviceStatus.NonCompliant)
                    return "Non-Compliant";

                return "Healthy";
            }
        }

        // Provides friendly display text when Device objects are placed directly into ListBox controls.
        public override string ToString()
        {
            return $"{DeviceName} | {DeviceType} | {Status}";
        }
    }
}
