using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Core.Domain
{
    public class Ticket : Entity
    {
        public Guid EventId { get; protected set; }
        public int Seating { get; protected set; }
        public decimal Prince { get; protected set; }
        public Guid? UserId { get; protected set; }
        public int Username { get; protected set; }
        public DateTime? PurchaseAt { get; protected set; }
        public bool Purchased => UserId.HasValue;

        public bool PurchasedAt => UserId.HasValue;

        protected Ticket()
        {
        }
        public Ticket(Event @event, int seating, decimal prince)
        {
            EventId = @event.Id;
            Seating = seating;
            Prince = prince;
        }
    }
}