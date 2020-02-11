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
    public class DetailsModel : PageModel
    {
        private readonly BudgetApp.Data.BudgetAppContext _context;

        public DetailsModel(BudgetApp.Data.BudgetAppContext context)
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

            Budget = await _context.Budget.FirstOrDefaultAsync(m => m.Id == id);

            if (Budget == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
