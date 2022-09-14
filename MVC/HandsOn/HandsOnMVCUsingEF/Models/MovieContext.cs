using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HandsOnMVCUsingEF.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext():base("name=MovieDBConn")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}