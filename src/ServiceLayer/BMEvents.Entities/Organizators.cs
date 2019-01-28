using System;
using System.Collections.Generic;
using System.Text;
using BMEvents.Entities.Base;

namespace BMEvents.Entities
{
    public class Organizators : BaseEntity
    {
        public int OrganizatorId { get; set; }

        public string OrganizatorName { get; set; }

        public string PhoneNumber { get; set; }

        public string EMail { get; set; }

        public bool IsActive { get; set; }
    }
}