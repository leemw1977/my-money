﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Data;
using Web.PersistenceModels;

namespace Web.Pages.Budgets
{
    public class CreateModel : PageModel
    {
        private readonly Web.Data.MyMoneyContext _context;

        public CreateModel(Web.Data.MyMoneyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Budget Budget { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Budgets.Add(Budget);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
