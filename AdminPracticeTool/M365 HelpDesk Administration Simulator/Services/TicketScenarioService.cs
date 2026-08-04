using M365_HelpDesk_Administration_Simulator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace M365_HelpDesk_Administration_Simulator.Services
{
    public static class TicketScenarioService
    {
       

        public static List<TicketScenario> LoadScenariosFromJson()
        {
            string filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Data",
                "ticket-scenarios.json"
            );

            if (!File.Exists(filePath))
                return new List<TicketScenario>();

            string json = File.ReadAllText(filePath);

            var scenarios = JsonConvert.DeserializeObject<List<TicketScenario>>(json);

            return scenarios ?? new List<TicketScenario>();
        }
    }

}

