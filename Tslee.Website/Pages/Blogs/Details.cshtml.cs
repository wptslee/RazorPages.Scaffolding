using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tslee.Website.Data;
using Tslee.Website.Models;

namespace Tslee.Website.Pages.Blogs
{
    public class DetailsModel : PageModel
    {
        private readonly Tslee.Website.Data.ApplicationDbContext _context;

        public DetailsModel(Tslee.Website.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Blog Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog = await _context.Blog.FirstOrDefaultAsync(m => m.Id == id);

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
