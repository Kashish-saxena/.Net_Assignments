using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreApp.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new()
        {
    new Book { Id = 1, Title = "Pride and Prejudice", Author = "Jane Austen", Price = 14.99M, },
    new Book { Id = 2, Title = "1984", Author = "George Orwell", Price = 18.50M },
    new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 16.00M,},
    new Book { Id = 4, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 13.99M },

        };

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            return View(book);
        }
    }
}
