﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //Esta classe está OK, pois realmente precisa implementar todas as propriedades e métodos da interface ILibraryItem
    public class Book : ILibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

        public void CheckIn ()
        {
            Borrower = "";
        }

        public void CheckOut (string borrower)
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
