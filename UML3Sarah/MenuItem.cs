using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3Sarah
{
    public abstract class MenuItem : IMenuItem
    {
        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }
        public virtual string PrintInfo()
        {
            return $"\n\n\t Number: {Number}. Name: {Name}. \n\tDesc: {Description}. \n\tPrice: {Price},-. Category: {Type}. Vegan: {IsVegan}. Organic: {IsOrganic}.";
        }
        
    }
}
