using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookKeeper.Data;

namespace BookKeeper.Pages.Scaffolding.CategoryTypeScaffold
{
    public class IndexModel : PageModel
    {
        private readonly BookKeeper.Data.BookKeeperDbContext _context;

        public IndexModel(BookKeeper.Data.BookKeeperDbContext context)
        {
            _context = context;
        }

        public IList<CategoryType> CategoryType { get;set; }

        public async Task OnGetAsync()
        {
            CategoryType = await _context.CategoryTypes.ToListAsync();
        }
    }
}
