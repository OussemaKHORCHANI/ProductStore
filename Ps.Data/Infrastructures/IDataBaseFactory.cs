using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Infrastructures
{
   public interface IDataBaseFactory: IDisposable
    {
        DbContext DataContext { get; }
    }
}
