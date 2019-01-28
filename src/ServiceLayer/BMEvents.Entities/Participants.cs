using System;
using BMEvents.Entities.Base;

namespace BMEvents.Entities
{
    public class Participants : BaseEntity
    {
        public int ParticipantId { get; set; }

        public string ParticipantName { get; set; }

        public string ParticipantLastName { get; set; }

        public int Gender { get; set; }

        public string EMail { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
    }
}