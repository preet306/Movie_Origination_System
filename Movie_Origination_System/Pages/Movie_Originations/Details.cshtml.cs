﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movie_Origination_System.Business;
using Movie_Origination_System.Data;

namespace Movie_Origination_System.Pages.Movie_Originations
{
    public class DetailsModel : PageModel
    {
        private readonly Movie_Origination_System.Data.Movie_Origination_System_DB _context;

        public DetailsModel(Movie_Origination_System.Data.Movie_Origination_System_DB context)
        {
            _context = context;
        }

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
    }
}
