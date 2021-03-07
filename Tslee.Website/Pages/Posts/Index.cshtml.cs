using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tslee.Website.Data;
using Tslee.Website.Models;

namespace Tslee.Website.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly Tslee.Website.Data.ApplicationDbContext _context;

        public IndexModel(Tslee.Website.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post
                .Include(p => p.Blog).ToListAsync();
        }
    }
}
