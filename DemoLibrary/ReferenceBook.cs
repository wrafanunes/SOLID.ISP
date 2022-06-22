using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*Esta classe viola o Princípio de Segregação de Interface, já que um livro de referência de uma biblioteca
     * não pode ser emprestado, sendo assim, não pode ter as propriedades CheckOutDurationInDays, Borrower e
     BorrowerDate*/
    public class ReferenceBook : ILibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CheckOutDurationInDays { get; set; } = 0;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

        //métodos não implementados, pois não são necessários
        public void CheckIn ()
        {
            throw new NotImplementedException();
        }

        public void CheckOut (string borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate ()
        {
            throw new NotImplementedException();
        }
    }
}
