using ConsoleStoreASP.Data.Interfaces;
using ConsoleStoreASP.Data.Models;
using System.Collections.Generic;

namespace ConsoleStoreASP.Data.Repository
{
    public class ArrCategory : IConsolesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Стационарные (домашние)", descr = "Обязателен постоянный источник питания, монитор/телевизор"},
                    new Category { categoryName = "Портативные (карманные)", descr = "Возможность взять с собой без требований"}
                };
            }
        }
    }
}
