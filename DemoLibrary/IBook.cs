using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*IBook contém as propriedades usadas pela classe Book, e implementa a interface ILibraryItem, já que esta possui
    propriedades que também são necessárias para classe Book*/
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
