using Ev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Core.Repositories
{
    public interface IEventRepository
    {
        Task<Event>GetAsync(Guid id);
        Task<Event>GetAsync(string name);
        Task<IEnumerable<Event>> BrowseAsync(string name = " ");
        Task AddSync(Event @event);
        Task UpdateAsync(Event @event);
        Task DeletAsync(Event @Event);
    }
}
