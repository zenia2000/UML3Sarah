using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Sarah
{
    public class Sandwich : MenuItem
    {
        public string _bun;

        public Sandwich(int number,string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, string bun)
            : base(number,name, description, price, type, isVegan, isOrganic)
        {
            _bun = bun;
        }
        public bool bun { get; set; }
        public override string PrintInfo()
        {
            return base.PrintInfo() + $"\t Sandwich bun: {_bun}";
        }
    }
}
