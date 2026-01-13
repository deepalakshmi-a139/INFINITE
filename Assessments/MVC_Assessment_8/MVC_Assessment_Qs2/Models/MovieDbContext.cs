using MVC_Assessment_Qs2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Assessment_Qs2.Models
{ 
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext() : base("MoviesDB") { }
        public DbSet<Movie> Movies { get; set; }
    }
}
