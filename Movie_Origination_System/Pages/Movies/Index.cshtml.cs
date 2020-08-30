using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movie_Origination_System.Business;
using Movie_Origination_System.Data;

namespace Movie_Origination_System.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Movie_Origination_System.Data.Movie_Origination_System_DB _context;

        public IndexModel(Movie_Origination_System.Data.Movie_Origination_System_DB context)
        {
            _context = context;
        }

        public IList<Movie_details> Movie_details { get;set; }

        public async Task OnGetAsync()
        {
            Movie_details = await _context.Movie_details.ToListAsync();
        }
    }
}
