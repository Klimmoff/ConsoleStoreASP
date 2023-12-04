using ConsoleStoreASP.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleStoreASP.Data.Interfaces
{
    public interface IConsolesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
