using System;
using System.Collections.Generic;
using System.Text;
using BMEvents.Common.Enums;
using BMEvents.Dtos.Organizators;

namespace BMEvents.Dtos.Events
{
    public class EventDto
    {
        public int EventId { get; set; }

        public string EventName { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public EventTypes EventTypeId { get; set; }

        public OrganizatorDto OrganizatorId { get; set; }
    }
}