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

namespace Movie_Origination_System.Pages.Producers
{
    public class EditModel : PageModel
    {
        private readonly Movie_Origination_System.Data.Movie_Origination_System_DB _context;

        public EditModel(Movie_Origination_System.Data.Movie_Origination_System_DB context)
        {
            _context = context;
        }

        [BindProperty]
        public Producer_details Producer_details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Producer_details = await _context.Producer_details.FirstOrDefaultAsync(m => m.Movie_Producer_ID == id);

            if (Producer_details == null)
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

            _context.Attach(Producer_details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Producer_detailsExists(Producer_details.Movie_Producer_ID))
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

        private bool Producer_detailsExists(int id)
        {
            return _context.Producer_details.Any(e => e.Movie_Producer_ID == id);
        }
    }
}
