using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.PersistenceModels;

namespace Web.Pages.Budgets
{
    public class DetailsModel : PageModel
    {
        private readonly Web.Data.MyMoneyContext _context;

        public DetailsModel(Web.Data.MyMoneyContext context)
        {
            _context = context;
        }

        public Budget Budget { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Budget = await _context.Budgets
                .Include(i => i.Incomings)
                .ThenInclude(it => it.Type)
                .Include(e => e.Outgoings)
                .ThenInclude(et => et.Type)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Budget == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
