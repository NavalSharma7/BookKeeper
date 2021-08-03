using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BookKeeper.Data;

namespace BookKeeper.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private BookKeeperDbContext _context { get; set; }

        public IEnumerable<Book> books;

        [FromForm]
        public Book book { get; set; }

        public IndexModel(ILogger<IndexModel> logger,BookKeeperDbContext context)
        {
            _logger = logger;
            _context = context;

           // books = new List<Book>();
        }

        public void OnGet()
        {

            books = _context.Books.ToList();
        }

        public void onPost() {
            if (!String.IsNullOrEmpty(book.Title))
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }

            books = _context.Books.ToList();
        }
    }
}
