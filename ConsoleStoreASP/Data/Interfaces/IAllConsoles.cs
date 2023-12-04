using ConsoleStoreASP.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleStoreASP.Data.Interfaces
{
    interface IAllConsoles
    {
        IEnumerable<Consoles> Consoles { get; }
        IEnumerable<Consoles> getFavConsole { get; }

        Consoles getSingleConsole(int consoleId);
    }
}
