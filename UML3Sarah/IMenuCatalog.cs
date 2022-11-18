using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Sarah
{
    public interface IMenuCatalog
    {
        int Count { get; }
        void Add(IMenuItem aMenuItem);
        IMenuItem Search(int number);
        void Delete(IMenuItem aMenuItem);
        void PrintPizzasMenu();
        void PrintBeveragesMenu();
        void PrintSandwichMenu();
        void Update(int number, IMenuItem theMenuItem);
        List<IMenuItem> FindAllVegan(MenuType type);
        List<IMenuItem> FindAllOrganic(MenuType type);
        IMenuItem MostExpensiveMenuItem();
    }

}
