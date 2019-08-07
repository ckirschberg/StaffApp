using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StaffApp.Models
{
    public class StaffEntity
    {
		public int StaffEntityId { get; set; }
        [Required(ErrorMessage ="First name must be filled out")] public string Firstname { get; set; }
        [Required] public string Lastname { get; set; }
        [Required] [EmailAddress] public string Email { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public StaffEntity()
        {

        }
    }
}
