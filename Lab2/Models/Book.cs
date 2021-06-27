using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string NameBook { get; set; }

        public string Author { get; set; }

        public string Style { get; set; }

        public string Year { get; set; }

        public string Information { get; set; }

    }
}