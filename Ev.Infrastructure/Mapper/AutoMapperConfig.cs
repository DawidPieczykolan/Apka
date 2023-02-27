using AutoMapper;
using Ev.Core.Domain;
using Ev.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Infrastructure.Mapper
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventDto>()
                   .ForMember(x => x.TicketsCount, m => m.MapFrom(p => p.Tickets.Count()));
            })
            .CreateMapper();
    }
}
