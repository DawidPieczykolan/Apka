<<<<<<< HEAD
﻿using AutoMapper;
using Ev.Core.Repositories;
=======
﻿using Ev.Core.Repositories;
>>>>>>> 0fa619db738655332d73210f940f0584b902ae08
using Ev.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Infrastructure.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
<<<<<<< HEAD
        private readonly IMapper _mapper;
        public EventService(IEventRepository eventRepository, IMapper mapper) 

        {
            _eventRepository= eventRepository;
            _mapper= mapper;
=======
        public EventService(IEventRepository eventRepository) 
        {
            _eventRepository= eventRepository;
>>>>>>> 0fa619db738655332d73210f940f0584b902ae08
        }
        public async Task<EventDto> GetAsync(Guid id)
        {
            var @event =await _eventRepository.GetAsync(id);
            
<<<<<<< HEAD
            return _mapper.Map<EventDto>(@event);
=======
            return new EventDto
            {
                Id = @event.Id,
                Name = @event.Name,
            };
>>>>>>> 0fa619db738655332d73210f940f0584b902ae08
        }

        public async Task<EventDto> GetAsync(string name)
        {
            var @event = await _eventRepository.GetAsync(name);
<<<<<<< HEAD

            return _mapper.Map<EventDto>(@event);
=======
            return new EventDto
            {
                Id = @event.Id,
                Name = @event.Name,
            };
>>>>>>> 0fa619db738655332d73210f940f0584b902ae08
        }

        public async Task<IEnumerable<EventDto>> BrowseAsync(string name = null)
        {
            var @events = await _eventRepository.BrowseAsync(name);
<<<<<<< HEAD
           return _mapper.Map<IEnumerable<EventDto>>(@events);  
=======
            return events.Select(@event=>new EventDto
            {
                Id = @event.Id,
                Name = @event.Name,
            });
>>>>>>> 0fa619db738655332d73210f940f0584b902ae08
        }

        public async    Task CreateAsync(Guid id, string name, string description, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public async Task AddTicketAsync(Guid eventId, int amount, decimal prince)
        {
            throw new NotImplementedException();
        }

        public async Task UpadeAsync(Guid id, string name, string description)
        {
            throw new NotImplementedException();
        }



        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        

       
    }
}
