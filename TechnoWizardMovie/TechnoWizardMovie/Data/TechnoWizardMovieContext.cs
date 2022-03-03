using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechnoWizardMovie.Models;

namespace TechnoWizardMovie.Data
{
    public class TechnoWizardMovieContext : DbContext
    {
        public TechnoWizardMovieContext (DbContextOptions<TechnoWizardMovieContext> options)
            : base(options)
        {
        }

        public DbSet<TechnoWizardMovie.Models.Movie> Movie { get; set; }
    }
}
