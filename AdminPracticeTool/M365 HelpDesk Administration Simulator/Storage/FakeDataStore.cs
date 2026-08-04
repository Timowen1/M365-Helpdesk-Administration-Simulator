using M365_HelpDesk_Administration_Simulator.Models;
using System.Collections.Generic;


namespace M365_HelpDesk_Administration_Simulator.Storage
{
    public class FakeDataStore
    {
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();

        public List<SecurityGroup> Groups { get; set; } = new List<SecurityGroup>();

        public List<Device> Devices { get; set; } = new List<Device>();

        public List<AuditEntry> AuditEntries { get; set; } = new List<AuditEntry>();

    }

}
