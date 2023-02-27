using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Core.Domain
{
    public class Event : Entity
    {
        private ISet<Ticket> _tickets = new HashSet<Ticket>();

        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime EndData { get; protected set; }
        public DateTime UpdadedAt { get; protected set; }

        public IEnumerable<Ticket> Tickets => _tickets;

        protected Event()
        {

        }
        public Event(Guid id, string name, string description, DateTime createdAt, DateTime startDate, DateTime endData, DateTime updadedAt)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
            StartDate = startDate;
            EndData = endData;
            UpdadedAt = updadedAt;
            CreatedAt = DateTime.UtcNow;
            UpdadedAt = DateTime.UtcNow;
        }

        public void AddTickets(int amont, decimal prince)
        {
            var seting = _tickets.Count + 1;
            for (var i = 0; i < amont; i++)
            {
                _tickets.Add(new Ticket(this, 0, prince));
            }
        }



    }
}