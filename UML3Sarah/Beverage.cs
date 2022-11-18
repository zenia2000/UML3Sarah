using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Sarah
{
    public class Beverage : MenuItem
    {
        public bool _alcoholic;
        
        public Beverage (int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcoholic)
            :base(number,name, description, price, type, isVegan, isOrganic)
        {
            _alcoholic = alcoholic;
        }
        public bool alcoholic { get; set; }
        public override string PrintInfo()
        {
            return base.PrintInfo() + $" \tAlcoholic: {_alcoholic}";
        }
    }
}
