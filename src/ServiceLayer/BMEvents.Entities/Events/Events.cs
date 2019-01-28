using System;
using System.ComponentModel.DataAnnotations.Schema;
using BMEvents.Entities.Base;

namespace BMEvents.Entities.Events
{
    public class Events : BaseEntity
    {
        public int EventId { get; set; }

        public string EventName { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("EventTypeId")]
        public EventTypes EventTypeId { get; set; }

        [ForeignKey("OrganizatorId")]
        public Organizators OrganizatorId { get; set; }
    }
}