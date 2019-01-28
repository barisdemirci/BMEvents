using BMEvents.Entities.Base;

namespace BMEvents.Entities.Events
{
    public class EventTypes : BaseEntity
    {
        public int EventTypeId { get; set; }

        public string EventTypeName { get; set; }
    }
}