﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.GeneralInterfaces
{
    //Agora esta interface contém somente as propriedades que todas as classes herdarão
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
    }
}
