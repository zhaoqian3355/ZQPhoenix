using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZQNet.Presentation.Web.ZQPhoenix.Models;

namespace ZQNet.Presentation.Web.ZQPhoenix.Repository
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}