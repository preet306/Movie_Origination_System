using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Movie_Origination_System.Business;
using Movie_Origination_System.Data;

namespace Movie_Origination_System.Pages.Producers
{
    public class CreateModel : PageModel
    {
        private readonly Movie_Origination_System.Data.Movie_Origination_System_DB _context;

        public CreateModel(Movie_Origination_System.Data.Movie_Origination_System_DB context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Producer_details Producer_details { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Producer_details.Add(Producer_details);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
