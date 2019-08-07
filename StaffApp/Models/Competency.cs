using System;
using System.Collections.Generic;

namespace StaffApp.Models
{
    public class Competency
    {
        public int CompetencyId { get; set; }
        public string Name { get; set; }

        // public ICollection<StaffEntity> Staffs { get; set; }

        public Competency()
        {
        }
    }
}
