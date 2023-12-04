using ConsoleStoreASP.Data.Interfaces;
using ConsoleStoreASP.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleStoreASP.Data.Repository
{
    public class ArrConsoles : IAllConsoles
    {
        private readonly IConsolesCategory _consolesCategory = new ArrCategory();

        public IEnumerable<Consoles> Consoles 
        {
            get
            {
                return new List<Consoles>
                {
                    new Consoles
                    {
                        name = "Play Station 4",
                        shortDesc = "Старое поколение. Поддерживает часть игр",
                        longDesc = "Достаточно устарела для частого потреблеия. Имеет обширный список игр",
                        img = "string",
                        price = 8000,
                        avilable = true,
                        _Category = _consolesCategory.AllCategories.First()
                    },
                    new Consoles
                    {
                        name = "Play Station 5",
                        shortDesc = "Младшее и более современное поколение PS",
                        longDesc = "Приставка нового поколения. Поддерживает большинство продуктов, а также имеет продолжительную поддержку",
                        img = "string",
                        price = 18000,
                        avilable = true,
                        _Category = _consolesCategory.AllCategories.First()

                    },

                    new Consoles
                    {
                        name = "Steam Deck",
                        shortDesc = "Новейшая портативная консоль",
                        longDesc = "Самый свежий выпуск среди всех современных карманных консолей",
                        img = "string",
                        price = 25000,
                        avilable = false,
                        _Category = _consolesCategory.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Consoles> getFavConsole => throw new NotImplementedException();

        public Consoles getSingleConsole(int consoleId)
        {
            throw new NotImplementedException();
        }
    }
}
