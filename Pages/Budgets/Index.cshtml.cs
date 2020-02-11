using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BudgetApp.Data;
using BudgetApp.Models;

namespace BudgetApp.Pages.Budgets
{
    public class IndexModel : PageModel
    {
        private readonly BudgetApp.Data.BudgetAppContext _context;

        public IndexModel(BudgetApp.Data.BudgetAppContext context)
        {
            _context = context;
        }

        public IList<Budget> Budget { get;set; }

        public async Task OnGetAsync()
        {
            Budget = await _context.Budget.ToListAsync();
        }
    }
}
