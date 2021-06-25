using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;
using System.Data.Entity.Infrastructure;

namespace Lab2.Controllers
{
    public class BookController : Controller
    {
        // GET: ThucHanh
       
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1,"HTML & CSS The complete Manual","  Author Name Book 1","/Content/images/anh1.jpg"));
            books.Add(new Book(2,"HTML & CSS Responsive web Design cookbook " ,"Author Name Book 2", "/Content/images/anh2.jpg"));
            books.Add(new Book(3,"Professional ASP.NET MVC5 ", "Author Name Book 2", "/Content/images/anh3.jpg"));
            
            return View(books);
        }
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML & CSS The complete Manual", "  Author Name Book 1", "/Content/images/anh1.jpg"));
            books.Add(new Book(2, "HTML & CSS Responsive web Design cookbook ", "Author Name Book 2", "/Content/images/anh2.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC5 ", "Author Name Book 2", "/Content/images/anh3.jpg"));

            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }

            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);

        }
        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int Id, string Title, string Author, string ImageCover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML & CSS The complete Manual", "Author Name Book 1", "/Content/images/book1cover.jpg"));
            books.Add(new Book(2, "HTML & CSS Responsive web Design cookbook", "Author Name Book 2", "/Content/images/book2cover.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 2", "/Content/images/book3cover.jpg"));

            if (Id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == Id)
                {
                    b.Title = Title;
                    b.Author = Author;
                    b.Imagecover = ImageCover;
                    break;
                }
            }
            return View("ListBookModel", books);
        }
         [HttpPost, ActionName("CreateBook")]
        [ValidateAntiForgeryToken]

        public ActionResult Contact([Bind(Include = "Id,Title,Author,ImageCover")] Book book)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML & CSS The complete Manual", "Author Name Book 1", "/Content/images/book1cover.jpg"));
            books.Add(new Book(2, "HTML & CSS Responsive web Design cookbook", "Author Name Book 2", "/Content/images/book2cover.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 2", "/Content/images/book3cover.jpg"));
            try
            {
                if (ModelState.IsValid)
                {
                    books.Add(book);
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Error Save Data");

            }
            return View("ListBookModel", books);
        }


    }

}