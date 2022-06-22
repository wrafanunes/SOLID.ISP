using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*Interface para uso exclusivo da classe Book, é uma interface vazia que implementa IBorrowable e IBook, portanto,
    * todas as propriedades e métodos necessários para Book estarão presentes*/
    public interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
