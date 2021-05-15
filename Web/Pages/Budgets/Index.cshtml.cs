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
    public class IndexModel : PageModel
    {
        private readonly Web.Data.MyMoneyContext _context;

        public IndexModel(Web.Data.MyMoneyContext context)
        {
            _context = context;
        }

        public IList<Budget> Budget { get;set; }

        public async Task OnGetAsync()
        {
            Budget = await _context.Budgets.ToListAsync();
        }
    }
}
