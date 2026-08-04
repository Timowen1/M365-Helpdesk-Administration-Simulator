using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M365_HelpDesk_Administration_Simulator.Models
{
    public  class EmailIssue
    {
        public enum EmailIssueType
        {
            CannotSendEmail,
            CannotReceiveEmail,
            MailboxFull,
            IncorrectForwardingRule,
            QuarantinedMessage,
            SharedMailboxAccess,
            DistributionGroupMembership,
            OutlookProfileIssue
        }



    }
}
