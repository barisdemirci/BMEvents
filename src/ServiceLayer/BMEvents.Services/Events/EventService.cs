using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BMEvents.Dtos.Events;

namespace BMEvents.Services.Events
{
    public class EventService : IEventService
    {
        public Task<EventDto> GetEventAsync(int eventId)
        {
            return Task.FromResult(new EventDto() { EventId = 11 });
        }
    }
}