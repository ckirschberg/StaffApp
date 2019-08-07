using System;
using System.Collections.Generic;

namespace StaffApp.Models
{
    public class StaffEntity
    {
		public int StaffEntityId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        // public ICollection<Competency> Competencies { get; set; }

        public StaffEntity()
        {

        }
    }
}
