using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Razrab.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(nameOrConnectionString: "PgConnectionString") { }

        public DbSet<DirectionTraining> DirectionTraining { get; set; }
        public DbSet<Orientation> Orientation { get; set; }
        public DbSet<OrientationTechnology> OrientationTechnology { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<TechnologyVacancy> TechnologyVacancy { get; set; }
        public DbSet<Univercity> Univercity { get; set; }
        public DbSet<Vacancy> Vacancy { get; set; }

    }
}