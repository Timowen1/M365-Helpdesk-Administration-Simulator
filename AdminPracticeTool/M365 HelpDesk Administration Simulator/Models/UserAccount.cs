using System;
using System.Collections.Generic;


namespace M365_HelpDesk_Administration_Simulator.Models
{
    // Simulated lifecycle states for a user account.
    public enum UserStatus
    {
        Active,
        Disabled,
        SoftDeleted
    }

    // Simulated roles used by the practice admin tool.
    public enum UserRole
    {
        User,
        Helpdesk,
        Manager,
        Administrator
    }
    // Represents a simulated user identity in the fake tenant.
    // Includes account lifecycle, role/group/device assignments, and mailbox state.
    public class UserAccount
    {
        // Internal unique user identifier.
        public Guid Id { get; set; } = Guid.NewGuid();

        // User's first name.
        public string FirstName { get; set; }
        // User's last name.
        public string LastName { get; set; }

        // Convenience display name used throughout the UI.
        public string DisplayName => $"{FirstName} {LastName}";

        // Simulated work email address.
        public string Email { get; set; }

        // Department used for filtering and onboarding validation.
        public string Department { get; set; }

        // Current account lifecycle state.
        public UserStatus Status { get; set; } = UserStatus.Active;

        // Simulated role/access level for the account.
        public UserRole Role { get; set; } = UserRole.User;

        // Groups this user belongs to.
        public List<Guid> GroupIds { get; set; } = new List<Guid>();

        // Devices currently assigned to this user.
        public List<Guid> DeviceIds { get; set; } = new List<Guid>();

        // When this simulated account was created.
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Whether the user has a simulated mail license.
        public bool HasMailLicense { get; set; } = true;

        // Whether the user's mailbox is blocked.
        public bool MailboxBlocked { get; set; } = false;

        // Whether the user's mailbox is full.
        public bool MailboxFull { get; set; } = false;

        // Whether mail forwarding is enabled.
        public bool ForwardingEnabled { get; set; } = false;

        // Destination address for simulated mail forwarding.
        public string ForwardingAddress { get; set; } = "";

        // Calculated mailbox summary used by the UI and email tickets.
        public string MailboxStatus
        {
            get
            {
                if (!HasMailLicense)
                    return "No License";

                if (MailboxBlocked)
                    return "Blocked";

                if (MailboxFull)
                    return "Mailbox Full";

                if (ForwardingEnabled)
                    return "Forwarding Enabled";

                return "Healthy";
            }
        }

    }
}
