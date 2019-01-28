using System;
using System.Collections.Generic;
using System.Text;

namespace BMEvents.Dtos.Organizators
{
    public class OrganizatorDto
    {
        public int OrganizatorId { get; set; }

        public string OrganizatorName { get; set; }

        public string PhoneNumber { get; set; }

        public string EMail { get; set; }

        public bool IsActive { get; set; }
    }
}