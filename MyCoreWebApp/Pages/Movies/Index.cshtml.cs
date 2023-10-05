using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyCoreWebApp.Data;
using MyCoreWebApp.Models;

namespace MyCoreWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyCoreWebApp.Data.MyCoreWebAppContext _context;

        public IndexModel(MyCoreWebApp.Data.MyCoreWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
