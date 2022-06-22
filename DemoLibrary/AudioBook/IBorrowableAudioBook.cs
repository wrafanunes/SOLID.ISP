using DemoLibrary.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.AudioBook
{
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable
    {
    }
}
