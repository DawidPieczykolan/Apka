using Ev.Core.Domain;
using Ev.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Infrastructure.Services
{
    public interface IEventService
    {
        Task<EventDto> GetAsync(Guid id);
        Task<EventDto> GetAsync(string name);
        Task<IEnumerable<EventDto>> BrowseAsync(string name = null);
        Task CreateAsync(Guid id, string name, string description, DateTime startDate, DateTime endDate);
        Task AddTicketAsync(Guid eventId,int amount,decimal prince );
        Task UpadeAsync(Guid id, string name, string description);
        Task DeleteAsync(Guid id);
    }
}
