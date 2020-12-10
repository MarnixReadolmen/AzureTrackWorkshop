using Microsoft.EntityFrameworkCore;
using RMotownFestival.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMotownFestival.Api.DAL
{
    public class MotownDbContext: DbContext
    {
        public MotownDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
    }
}
