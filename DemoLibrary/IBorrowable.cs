using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*contém todas as propriedades e métodos das classes que definem itens emprestáveis (como livros, DVDs, Audiolivros),
     * mas não implementa IBook, porque alguns itens que podem ser emprestados não possuem as propriedades de Book.
     * ex: DVD não possui Author e Pages*/
    public interface IBorrowable
    {
        int CheckOutDurationInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowDate { get; set; }
        void CheckOut (string borrower);
        void CheckIn ();
        DateTime GetDueDate ();
    }
}
