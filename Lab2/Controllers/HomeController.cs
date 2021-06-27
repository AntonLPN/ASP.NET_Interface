using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private readonly IInformationPerson informationPerson;
        private readonly ILibrary library;
        private List<Person> people;

        private List<Book> books;
        
        public HomeController(IInformationPerson informationPerson, ILibrary library)
        {
            //task 1
            this.informationPerson = informationPerson;
            this.library = library;
            people = new List<Person>();
            people.Add(new Person { FirstName = "Tom", LastName = "Hanks", DateOfBirth = "21.08.1986", Information = "Some information" });
            people.Add(new Person { FirstName = "Jon", LastName = "Smit", DateOfBirth = "21.08.1992", Information = "Some information 2" });
            people.Add(new Person { FirstName = "Doe", LastName = "Jon", DateOfBirth = "11.08.2000", Information = "Some information 3" });
            //task 2
            books = new List<Book>();
            books.Add(new Book { Id = 1, Author = "Tom", NameBook = "Forest", Style = "Roman", Year = "2003", Information = "1234" });
            books.Add(new Book { Id = 2, Author = "Jon", NameBook = "Unity", Style = "Knoweleg", Year = "2004", Information = "12" });
            books.Add(new Book { Id = 3, Author = "Doe", NameBook = "C#", Style = "Programming", Year = "2005", Information = "134" });

        }


        public ActionResult Index()
        {

            return View(informationPerson.GetName(people));
        }

        public ActionResult BooksV()
        {

            return View(library.GetListBookAuthor(books));
        }
    }
}