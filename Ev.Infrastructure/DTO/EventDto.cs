using Ev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Infrastructure.DTO
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndData { get; set; }
        public DateTime UpdadedAt { get;  set; }
        public int TicketsCount { get; set; }
      
    }
}
