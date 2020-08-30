using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_Origination_System.Business;

namespace Movie_Origination_System.Data
{
    public class Movie_Origination_System_DB : DbContext
    {
        public Movie_Origination_System_DB(DbContextOptions<Movie_Origination_System_DB> options)
            : base(options)
        {
        }

        public DbSet<Movie_Origination_System.Business.Movie_details> Movie_details { get; set; }

        public DbSet<Movie_Origination_System.Business.Director_details> Director_details { get; set; }

        public DbSet<Movie_Origination_System.Business.Producer_details> Producer_details { get; set; }

        public DbSet<Movie_Origination_System.Business.Movie_Origination_Table> Movie_Origination_Table { get; set; }
    }
}
