﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*Esta classe viola o Princípio de Segregação de Interface, já que um DVD não contém uma quantidade de
    páginas e nem um autor*/
    public class DVD : ILibraryItem
    {
        public string? LibraryId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; } = "";
        public int Pages { get; set; }
        public int CheckOutDurationInDays { get; set; } = -1;
        public string? Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public int RuntimeInMinutes { get; set; }
        public List<string>? Actors { get; set; }

        public void CheckIn ()
        {
            Borrower = "";
        }

        public void CheckOut (string? borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate ()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}