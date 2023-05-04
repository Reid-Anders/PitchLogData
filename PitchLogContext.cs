using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PitchLogLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogData
{
    public class PitchLogContext : DbContext
    {
        public DbSet<Route> Routes { get; set; }

        public DbSet<BoulderProblem> Boulders { get; set; }

        public DbSet<Area> Areas { get; set; }

        public DbSet<Sector> Sectors { get; set; }

        public DbSet<Pitch> Pitches { get; set; }

        public DbSet<BoulderSession> BoulderSessions { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PitchLogDB")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<EntityBase>();
            modelBuilder.Ignore<OwnedEntity>();
            modelBuilder.Ignore<Climb>();
            modelBuilder.Ignore<ClimbInstance>();


            modelBuilder.Entity<Route>(table =>
            {
                table.OwnsOne(route => route.Length,
                    length =>
                    {
                        length.Property(length => length.Value).HasColumnName("Length");
                        length.Property(length => length.Units).HasColumnName("LengthUnits");
                    });
            });

            var GradesList = new List<Grade>()
            {
                new Grade { ID = 1, Type = PitchLogLib.GradeType.YDS, Value = "5.5" },
                new Grade { ID = 2, Type = PitchLogLib.GradeType.YDS, Value = "5.6" },
                new Grade { ID = 3, Type = PitchLogLib.GradeType.YDS, Value = "5.7" },
                new Grade { ID = 4, Type = PitchLogLib.GradeType.YDS, Value = "5.8" },
                new Grade { ID = 5, Type = PitchLogLib.GradeType.YDS, Value = "5.9" },
                new Grade { ID = 6, Type = PitchLogLib.GradeType.YDS, Value = "5.10a" },
                new Grade { ID = 7, Type = PitchLogLib.GradeType.YDS, Value = "5.10b" },
                new Grade { ID = 8, Type = PitchLogLib.GradeType.YDS, Value = "5.10c" },
                new Grade { ID = 9, Type = PitchLogLib.GradeType.YDS, Value = "5.10d" },
                new Grade { ID = 10, Type = PitchLogLib.GradeType.YDS, Value = "5.11a" },
                new Grade { ID = 11, Type = PitchLogLib.GradeType.YDS, Value = "5.11b" },
                new Grade { ID = 12, Type = PitchLogLib.GradeType.YDS, Value = "5.11c" },
                new Grade { ID = 13, Type = PitchLogLib.GradeType.YDS, Value = "5.11d" },
                new Grade { ID = 14, Type = PitchLogLib.GradeType.YDS, Value = "5.12a" },
                new Grade { ID = 15, Type = PitchLogLib.GradeType.YDS, Value = "5.12b" },
                new Grade { ID = 16, Type = PitchLogLib.GradeType.YDS, Value = "5.12c" },
                new Grade { ID = 17, Type = PitchLogLib.GradeType.YDS, Value = "5.12d" },
                new Grade { ID = 18, Type = PitchLogLib.GradeType.YDS, Value = "5.13a" },
                new Grade { ID = 19, Type = PitchLogLib.GradeType.YDS, Value = "5.13b" },
                new Grade { ID = 20, Type = PitchLogLib.GradeType.YDS, Value = "5.13c" },
                new Grade { ID = 21, Type = PitchLogLib.GradeType.YDS, Value = "5.13d" },
                new Grade { ID = 22, Type = PitchLogLib.GradeType.YDS, Value = "5.14a" },
                new Grade { ID = 23, Type = PitchLogLib.GradeType.YDS, Value = "5.14b" },
                new Grade { ID = 24, Type = PitchLogLib.GradeType.YDS, Value = "5.14c" },
                new Grade { ID = 25, Type = PitchLogLib.GradeType.YDS, Value = "5.14d" },
                new Grade { ID = 26, Type = PitchLogLib.GradeType.YDS, Value = "5.15a" },
                new Grade { ID = 27, Type = PitchLogLib.GradeType.YDS, Value = "5.15b" },
                new Grade { ID = 28, Type = PitchLogLib.GradeType.YDS, Value = "5.15c" },
                new Grade { ID = 29, Type = PitchLogLib.GradeType.YDS, Value = "5.15d" },
                new Grade { ID = 30, Type = PitchLogLib.GradeType.VGrade, Value = "V0" },
                new Grade { ID = 31, Type = PitchLogLib.GradeType.VGrade, Value = "V1" },
                new Grade { ID = 32, Type = PitchLogLib.GradeType.VGrade, Value = "V2" },
                new Grade { ID = 33, Type = PitchLogLib.GradeType.VGrade, Value = "V3" },
                new Grade { ID = 34, Type = PitchLogLib.GradeType.VGrade, Value = "V4" },
                new Grade { ID = 35, Type = PitchLogLib.GradeType.VGrade, Value = "V5" },
                new Grade { ID = 36, Type = PitchLogLib.GradeType.VGrade, Value = "V6" },
                new Grade { ID = 37, Type = PitchLogLib.GradeType.VGrade, Value = "V7" },
                new Grade { ID = 38, Type = PitchLogLib.GradeType.VGrade, Value = "V8" },
                new Grade { ID = 39, Type = PitchLogLib.GradeType.VGrade, Value = "V9" },
                new Grade { ID = 40, Type = PitchLogLib.GradeType.VGrade, Value = "V10" },
                new Grade { ID = 41, Type = PitchLogLib.GradeType.VGrade, Value = "V11" },
                new Grade { ID = 42, Type = PitchLogLib.GradeType.VGrade, Value = "V12" },
                new Grade { ID = 43, Type = PitchLogLib.GradeType.VGrade, Value = "V13" },
                new Grade { ID = 44, Type = PitchLogLib.GradeType.VGrade, Value = "V14" },
                new Grade { ID = 45, Type = PitchLogLib.GradeType.VGrade, Value = "V15" },
                new Grade { ID = 46, Type = PitchLogLib.GradeType.VGrade, Value = "V16" },
                new Grade { ID = 47, Type = PitchLogLib.GradeType.VGrade, Value = "V17" }
            };

            modelBuilder.Entity<Grade>().HasData(GradesList);
        }
    }
}
