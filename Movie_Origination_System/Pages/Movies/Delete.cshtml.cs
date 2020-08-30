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
    public class DeleteModel : PageModel
    {
        private readonly Movie_Origination_System.Data.Movie_Origination_System_DB _context;

        public DeleteModel(Movie_Origination_System.Data.Movie_Origination_System_DB context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie_details Movie_details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie_details = await _context.Movie_details.FirstOrDefaultAsync(m => m.Movie_ID == id);

            if (Movie_details == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie_details = await _context.Movie_details.FindAsync(id);

            if (Movie_details != null)
            {
                _context.Movie_details.Remove(Movie_details);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
