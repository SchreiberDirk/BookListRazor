using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Book Book { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()       // IActionResult because we will redirect to another page
        {
            if (ModelState.IsValid)
            {
                await _db.Book.AddAsync(Book);          // hinzufügen der Daten
                await _db.SaveChangesAsync();           // Sichern der Daten in Datenbank
                return RedirectToPage("Index");         // weiterleitung an Index-Seite
            }
            else
            {
                return Page();
            }
        }
    }
}