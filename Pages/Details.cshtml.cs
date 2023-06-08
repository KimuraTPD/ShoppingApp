using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;

namespace ShoppingApp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ShoppingAppContext _context;

        public DetailsModel(ShoppingAppContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.userId == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
