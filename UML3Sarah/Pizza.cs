using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UML3Sarah
{
    public class Pizza : MenuItem
    {
        public bool _deepPan;
        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan)
            :base(number,name,description,price,type,isVegan,isOrganic)
        {
            _deepPan = deepPan;
        }

        public bool DeepPan 
        { 
            get { return _deepPan; } 
            set { _deepPan = value; } 
        }

        public override string PrintInfo()
        {
            return   base.PrintInfo() + $"\tDeepPan: {_deepPan}. ";
        }
    }
}
