﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeBook.Models;

namespace BeeBook.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> BooksOfTheWeek { get; set; }
    }
}
