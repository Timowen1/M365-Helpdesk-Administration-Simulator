using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M365_HelpDesk_Administration_Simulator.Models
{
    // Represents one administrative action taken inside the simulator.
    // The audit log is used both for user visibility and for ticket validation.
    public class AuditEntry
    {
        // Internal unique identifier for this audit entry.
        public Guid Id { get; set; } = Guid.NewGuid();

        // Time the simulated action was recorded.
        public DateTime Timestamp { get; set; } = DateTime.Now;

        // Who performed the action, for example "Helpdesk Admin" or "System".
        public string Actor { get; set; }

        // Short action name used by the UI and ticket validators.
        public string Action { get; set; }

        // User, device, group, or ticket affected by the action.
        public string Target { get; set; }

        // Human-readable details about what changed.
        public string Notes { get; set; }
    }
}
