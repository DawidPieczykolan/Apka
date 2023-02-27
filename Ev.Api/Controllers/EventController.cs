using Ev.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ev.Api.Controllers
{
    [Route("[controller]")]
    public class EventController:Controller
    {
        
        private readonly IEventService _eventService;
        public EventController(IEventService eventService) 
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult>Get(string name) 
        {
            var events =await _eventService.BrowseAsync(name);
            return Json(events);
        }




    }
}
