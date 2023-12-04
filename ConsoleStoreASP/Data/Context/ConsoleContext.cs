using ConsoleStoreASP.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStoreASP.Data.Context
{
    public class ConsoleContext : DbContext
    {
        public ConsoleContext(DbContextOptions<ConsoleContext> options) : base(options)
        {
            Database.EnsureCreated(); // Создает БД с таблицами при обращении к ней
        }

        public DbSet<Consoles> ConsoleTable { get; set; }
        public DbSet<Category> CategoryTable { get; set; }
    }
}
