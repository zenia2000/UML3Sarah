using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Sarah
{
    public class ItemCatalog : IMenuCatalog
    {
        private List<IMenuItem> _items;

        public ItemCatalog()
        {
            _items = new List<IMenuItem>();
        }
       
        public int Count
        {
            get { return _items.Count; }
        }
        
        
        public void PrintAll()
        {
            foreach (IMenuItem item in _items)
            {
                Console.WriteLine(item.PrintInfo()  );
            }
        }
        public void Add(IMenuItem item)
        {
            _items.Add(item);
        }


        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> organic = new List<IMenuItem> ();
            foreach (IMenuItem aMenuItem in _items)
            {
                if (aMenuItem.IsOrganic == true && aMenuItem.Type== type)
                {
                    organic.Add(aMenuItem);
                }
            }
            return organic;
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> vegan = new List<IMenuItem>();
            foreach (MenuItem aMenuItem in _items)
            {
                if(aMenuItem.IsVegan == true && aMenuItem.Type== type)
                {
                    vegan.Add(aMenuItem);
                }
            }
            return vegan;

        }

        
        


        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem menuItem in _items)
                if (menuItem.Type == MenuType.AlcoholicDrink || menuItem.Type== MenuType.SoftDrink)
                {
                    Console.WriteLine(menuItem);
                }
        }

        public void PrintPizzasMenu()
        {
            foreach (IMenuItem menuItem in _items)
                if (menuItem.Type == MenuType.Pizza)
                {
                    Console.WriteLine(menuItem);
                }
        }

        public void PrintSandwichMenu()
        {
            foreach (IMenuItem menuItem in _items)
                if (menuItem.Type == MenuType.Sandwich)
                {
                    Console.WriteLine(menuItem);
                }
        }

        public IMenuItem Search(int number)
        {
            foreach (IMenuItem item in _items)
            {
                if (item.Number == number)
                {
                    return item;
                }
                
                    
            }
            return null;
        }


        public void Update(int number, IMenuItem theMenuItem)
        {
            
        }

        public void Delete(IMenuItem aMenuItem)
        {
            _items.Remove(aMenuItem);
        }


        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem expensiveItem = _items[0];
            foreach(IMenuItem aMenuItem in _items)
            {
                if (aMenuItem.Price > expensiveItem.Price)
                {
                    expensiveItem = aMenuItem;
                }
            }
            return expensiveItem;
        }
        
        public void PrintVegan(List<IMenuItem> veganItems)
        {
            foreach (IMenuItem item in veganItems)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }
        public void PrintOrganic(List<IMenuItem> organicItems)
        {
            foreach (IMenuItem item in organicItems)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public void PrintExpensive()
        {
            Console.WriteLine();
        }
    }
}
