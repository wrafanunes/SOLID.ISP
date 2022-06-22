using DemoLibrary.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.AudioBook
{
    /*interface que contém a propriedade RuntimeInMinutes e implementa ILibraryItem, esta interface é muito importante,
     * pois no caso de ser criada uma classe ReferenceAudioBook (audiolivro que não pode ser emprestado), ela implementará
     * IAudioBook em vez de IBorrowableAudioBook*/
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
