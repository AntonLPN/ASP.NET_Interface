using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Library : ILibrary
    {
        public List<string> GetListBookAuthor(List<Book> books)
        {

            var wantedList = books.Select(b => b.Author);

            return wantedList.ToList();
        }
    }
}