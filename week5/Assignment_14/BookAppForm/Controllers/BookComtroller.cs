using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BookAppForm.Models; 

public class BooksController : Controller
{
    private static List<Book> _books = new List<Book>();
    private static int _nextId = 1;

    public ActionResult Create()
    {
        return View("BookForm", new Book());
    }

    public ActionResult Edit(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if (book == null)
            return NotFound();

        return View("BookForm", book);
    }

    [HttpPost]
    public ActionResult Save(Book book)
    {
        if (!ModelState.IsValid)
            return View("BookForm", book);

        if (book.Id == 0)
        {
            book.Id = _nextId++;
            _books.Add(book);
        }
        else
        {
            var existing = _books.FirstOrDefault(b => b.Id == book.Id);
            if (existing == null)
                return NotFound();

            existing.Title = book.Title;
            existing.Author = book.Author;
        }

        return RedirectToAction("Index");
    }
    public ActionResult Index()
    {
        return View(_books);
    }
}
