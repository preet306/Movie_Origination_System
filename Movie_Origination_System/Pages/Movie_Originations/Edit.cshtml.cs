using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie_Origination_System.Business;
using Movie_Origination_System.Data;

namespace Movie_Origination_System.Pages.Movie_Originations
{
    public class EditModel : PageModel
    {
        private readonly Movie_Origination_System.Data.Movie_Origination_System_DB _context;

        public EditModel(Movie_Origination_System.Data.Movie_Origination_System_DB context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie_Origination_Table Movie_Origination_Table { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie_Origination_Table = await _context.Movie_Origination_Table.FirstOrDefaultAsync(m => m.Movie_Origination_ID == id);

            if (Movie_Origination_Table == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Movie_Origination_Table).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie_Origination_TableExists(Movie_Origination_Table.Movie_Origination_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Movie_Origination_TableExists(int id)
        {
            return _context.Movie_Origination_Table.Any(e => e.Movie_Origination_ID == id);
        }
    }
}
