using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMEvents.Dtos.Events;
using BMEvents.Services.Events;
using Microsoft.AspNetCore.Mvc;

namespace BMEvents.WebApi.Controllers
{
    [Route("api/v1/[event]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService eventService;

        public EventController(IEventService eventService)
        {
            this.eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
        }

        [HttpGet]
        public async Task<EventDto> GetEventAsync(int eventId)
        {
            return await eventService.GetEventAsync(eventId);
        }
    }
}