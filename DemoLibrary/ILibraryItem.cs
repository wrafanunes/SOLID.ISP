﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        int Pages { get; set; }
        int CheckOutDurationInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckOut (string borrower);
        void CheckIn ();
        DateTime GetDueDate ();
    }
}
