using BMEvents.Dtos.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BMEvents.Services.Events
{
    public interface IEventService
    {
        Task<EventDto> GetEventAsync(int eventId);
    }
}