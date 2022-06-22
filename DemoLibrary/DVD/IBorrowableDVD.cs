using DemoLibrary.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DVD
{
    /*Também seria possível não implementar as interfaces IDVD e IBorrowable e deixar para implementá-las na própria
     * classe DVD, mas não é o ideal.
     * Ao implementar as interfaces IDVD e IBorrowable diretamente na interface IBorrowableDVD, é possível fazer 
     * o seguinte código: 
     * IBorrowableDVD dvd = new DVD(); <- dessa forma, dvd tem acesso a todas as propriedades e métodos contidos em
     * IBorrowableDVD, IDVD e IBorrowable*/
    public interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}
