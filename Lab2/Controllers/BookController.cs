using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;

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
        
    }
}