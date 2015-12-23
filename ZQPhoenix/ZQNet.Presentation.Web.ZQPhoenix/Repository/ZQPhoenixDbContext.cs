using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ZQNet.Presentation.Web.ZQPhoenix.Models;

namespace ZQNet.Presentation.Web.ZQPhoenix.Repository
{
    public class ZQPhoenixDbContext : DbContext
    {
        public ZQPhoenixDbContext():
            base("ZQPhoenixDbContext")
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}