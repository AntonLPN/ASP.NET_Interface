﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public interface ILibrary
    {
     
        List<string> GetListBookAuthor(List<Book> books);


    }
}
