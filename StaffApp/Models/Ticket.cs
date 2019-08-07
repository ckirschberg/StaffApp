using System;
namespace StaffApp.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public double Price { get; set; }

        // Navigation properties
        public int StaffEntityId { get; set; }
        public StaffEntity StaffEntity { get; set; }

        public Ticket()
        {
        }
    }
}
