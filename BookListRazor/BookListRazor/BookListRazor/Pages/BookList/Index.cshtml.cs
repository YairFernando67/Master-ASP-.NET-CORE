using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public IEnumerable<BookViewModel> Books { get; set; }

        [TempData]
        public string Message { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var Book = await _db.Book.FindAsync(id);
            if(Book== null)
            {
                return NotFound();
            }
            _db.Book.Remove(Book);
            await _db.SaveChangesAsync();
            Message = "Book deleted successfully";
            return RedirectToPage("Index");
        }
    }
}