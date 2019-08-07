using System;
using Microsoft.EntityFrameworkCore;

namespace StaffApp.Models
{
    public class StaffAppContext : DbContext
    {
        public StaffAppContext(DbContextOptions<StaffAppContext> options)
            : base(options)
        {
        }
        public DbSet<StaffEntity> StaffEntities { get; set; }
        public DbSet<Competency> Competencies { get; set; }
        public DbSet<Ticket> Tickets{ get; set; }

    }
}
