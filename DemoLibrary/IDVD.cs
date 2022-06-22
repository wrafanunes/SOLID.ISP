using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IDVD : ILibraryItem
    {
        /*a propriedade RuntimeInMinutes não viola o DRY (Do not Repeat Yourself), porque embora ela esteja presente
        * nas classes AudioBook e DVD, essas classes não possuem relação, elas não são a mesma coisa.*/
        int RuntimeInMinutes { get; set; }
        List<string> Actors { get; set; }
    }
}
