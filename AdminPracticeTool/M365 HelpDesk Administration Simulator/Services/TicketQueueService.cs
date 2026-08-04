using System;
using System.Collections.Generic;
using System.Linq;
using M365_HelpDesk_Administration_Simulator.Models;

namespace M365_HelpDesk_Administration_Simulator.Services
{
    public class TicketQueueService
    {
        private readonly Queue<TicketScenario> _ticketQueue = new Queue<TicketScenario>();
        private readonly Random _random = new Random();

        public int RemainingTickets => _ticketQueue.Count;

        public void LoadQueue(List<TicketScenario> scenarios)
        {
            _ticketQueue.Clear();

            var shuffledScenarios = scenarios
                .OrderBy(s => _random.Next())
                .ToList();

            foreach (var scenario in shuffledScenarios)
            {
                _ticketQueue.Enqueue(scenario);
            }
        }

        public TicketScenario GetNextTicket()
        {
            if (_ticketQueue.Count == 0)
                return null;

            return _ticketQueue.Dequeue();
        }

    }
}
