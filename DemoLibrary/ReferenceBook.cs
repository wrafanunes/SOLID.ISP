using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*Agora a classe ReferenceBook implementa IBook, que contém todas as informações de Book, exceto as propriedades
    * CheckOutDurationInDays, Borrower e BorrowerDate e nem os métodos CheckIn, CHeckOut e GetDueDate, que são
     informações necessárias apenas para livros que podem sair da biblioteca por empréstimo*/
    public class ReferenceBook : IBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}
