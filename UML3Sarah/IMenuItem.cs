using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum MenuType { Pizza, SoftDrink, AlcoholicDrink, Sandwich }
public interface IMenuItem
{
    int Number { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    double Price { get; set; }
    MenuType Type { get; set; }
    bool IsVegan { get; set; }
    bool IsOrganic { get; set; }
    string PrintInfo();
}

