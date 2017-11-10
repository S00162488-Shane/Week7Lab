using Rad2016SampleWepApp.Models.ClubModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week6Lab.Models.ClubModels
{
    public class ClubsDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public object Roles { get; internal set; }

        public ClubsDbContext()
            : base("DefaultConnection")
        {

        }

    }
}