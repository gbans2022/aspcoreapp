using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCoreWebApp.Models;

namespace MyCoreWebApp.Data
{
    public class MyCoreWebAppContext : DbContext
    {
        public MyCoreWebAppContext (DbContextOptions<MyCoreWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyCoreWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
