using ConsoleStoreASP.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStoreASP.Data.Models
{
    public class ConsolesPagingModel
    {
        public IEnumerable<Consoles> Consoles { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int CurrentCategory { get; set; }
    }
}
