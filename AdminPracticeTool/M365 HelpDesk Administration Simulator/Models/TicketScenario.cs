using System;
using System.Collections.Generic;


namespace M365_HelpDesk_Administration_Simulator.Models
{
    // Supported practice-ticket workflow categories.
    public enum TicketScenarioType
    {
        NewHireOnboarding,
        SalesDriveAccess,
        EmployeeOffboarding,
        ReplacementLaptop,
        LostLaptop,
        PasswordReset,
        EmailTroubleshooting,
        DeviceHealthTroubleshooting
    }

    // Represents one practice ticket loaded from ticket-scenarios.json.
    // Generic fields describe the ticket, while Required* fields tell validators
    // what user/group/email/device state is expected for that scenario type.
    public class TicketScenario
    {
        // Unique ticket identifier generated at runtime.
        public Guid Id { get; set; } = Guid.NewGuid();

        // Determines which checklist updater and validator handle this ticket.
        public TicketScenarioType ScenarioType { get; set; }

        // Short title shown in the Ticket Scenario panel.
        public string Title { get; set; }

        // Longer instructions shown to the trainee.
        public string Description { get; set; }

        // Email address used to locate the ticket's target user.
        public string TargetUserEmail { get; set; }

        // Checklist text shown in the Expected Actions list.
        public List<string> ExpectedActions { get; set; } = new List<string>();

        // Message shown after the ticket validates successfully.
        public string SuccessMessage { get; set; }

        // Expected first name for new-hire onboarding tickets.
        public string RequiredFirstName { get; set; }

        // Expected last name for new-hire onboarding tickets.
        public string RequiredLastName { get; set; }

        // Expected department for new-hire onboarding tickets.
        public string RequiredDepartment { get; set; }

        // Expected role for new-hire onboarding tickets.
        public UserRole RequiredRole { get; set; } = UserRole.User;

        // Required group for onboarding or access tickets.
        public string RequiredGroupName { get; set; }

        // Email issue key, such as MailboxFull or ForwardingEnabled.
        public string RequiredEmailIssue { get; set; }

        // Optional expected forwarding address for mail-forwarding scenarios.
        public string RequiredForwardingAddress { get; set; }

        // Device issue key, such as WindowsUpdatePending or LowDiskSpace.
        public string RequiredDeviceIssue { get; set; }

        // Device name the ticket expects the trainee to troubleshoot.
        public string RequiredDeviceName { get; set; }

    }
}
