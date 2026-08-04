using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M365_HelpDesk_Administration_Simulator.Models
{
    // Optional/simple model for Windows health settings.
    // Most active device-health logic currently lives directly on Device.
    public class WindowsDeviceHealth
    {
        // Whether BitLocker is enabled.
        public bool BitLockerEnabled { get; set; }
        // Whether Windows updates are pending.
        public bool WindowsUpdatePending { get; set; }
        // Whether Microsoft Defender is enabled.
        public bool DefenderEnabled { get; set; }
        // Whether temporary local admin is granted.
        public bool LocalAdminGranted { get; set; }
        // Whether Remote Desktop is enabled.
        public bool RemoteDesktopEnabled { get; set; }
        // Free disk space percentage.
        public int DiskSpacePercentFree { get; set; }
        // Human-readable device check-in status.
        public string LastCheckInStatus { get; set; }


    }
}