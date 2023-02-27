using Ev.Core.Domain;
using Ev.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        //dodać poloczneie z Mysql

        private static readonly ISet<Event> _events = new HashSet<Event>
        {
             new Event(Guid.NewGuid(),"Event 1","Event 1 discription", DateTime.UtcNow.AddHours(2),DateTime.UtcNow.AddHours(4)),
             new Event(Guid.NewGuid(),"Event 2","Event 2 discription",DateTime.UtcNow.AddHours(5),DateTime.UtcNow.AddHours(10)),

        };

        public async Task<Event> GetAsync(Guid id)
        => await Task.FromResult(_events.SingleOrDefault(x => x.Id == id));

        public async Task<Event> GetAsync(string name)
        => await Task.FromResult(_events.SingleOrDefault(x => x.Name.ToLowerInvariant() == name));

        public async Task<IEnumerable<Event>> BrowseAsync(string name = " ")
        {
            var events = _events.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(name));
            {
                events=events.Where(x=>x.Name.ToLowerInvariant()
                .Contains(name.ToLowerInvariant()));
            }
            return await Task.FromResult(events);       
        }


        public async Task AddSync(Event @event)
        {
            _events.Add(@event);
            await Task.CompletedTask;
        }
        public async Task UpdateAsync(Event @event)
        {
            await Task.CompletedTask;
        }


        public async Task DeletAsync(Event @event)
        {
            _events.Remove(@event);
            await Task.CompletedTask;
        }

       
    }
}
