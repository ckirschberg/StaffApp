using System;
using System.Linq;
using StaffApp.Models;

namespace StaffApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StaffAppContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.StaffEntities.Any())
            {
                return;   // DB has been seeded
            }

            var staff = new StaffEntity[]
            {
                new StaffEntity{Firstname="Carson",Lastname="Alexander",Email="c@a.dk"},
                new StaffEntity{Firstname="Per",Lastname="Jensen",Email="per@per.dk"},
                new StaffEntity{Firstname="Hans",Lastname="Hansen",Email="hans@hans.dk"},
            };
            foreach (StaffEntity s in staff)
            {
                context.StaffEntities.Add(s);
            }
            context.SaveChanges();
        }
    }
}
