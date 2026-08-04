using System;
using System.Collections.Generic;

namespace M365_HelpDesk_Administration_Simulator.Models
{
    // Represents a simulated security/access group used for shared-drive or role-based access.
    public class SecurityGroup
    {
        // Internal unique group identifier.
        public Guid Id { get; set; } = Guid.NewGuid();

        // Group display name, such as Sales-SharedDrive-Access.
        public string Name { get; set; }

        // Short explanation of what access this group provides.
        public string Description { get; set; }

        // User IDs currently assigned to this group.
        public List<Guid> MemberUserIds { get; set; } = new List<Guid>();

        // Text shown in group dropdowns, including the current member count.
        public string DisplayLabel => $"{Name} ({MemberUserIds.Count} members)";

    }
}
