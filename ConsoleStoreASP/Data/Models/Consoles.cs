using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStoreASP.Data.Models
{
    public class Consoles
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public short price { get; set; }
        public bool avilable { get; set; }
        public int CategoryId { get; set; }
        public virtual Category _Category { get; set; }
    }
}
