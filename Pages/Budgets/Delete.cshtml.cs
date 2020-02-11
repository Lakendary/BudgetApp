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
    public class DeleteModel : PageModel
    {
        private readonly BudgetApp.Data.BudgetAppContext _context;

        public DeleteModel(BudgetApp.Data.BudgetAppContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Budget = await _context.Budget.FindAsync(id);

            if (Budget != null)
            {
                _context.Budget.Remove(Budget);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
