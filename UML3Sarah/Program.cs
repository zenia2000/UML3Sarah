// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using UML3Sarah;



Pizza P1 = new Pizza(1,"Felix", "Pepperoni", 80.95,MenuType.Pizza, false, false, true);
Pizza P2 = new Pizza(2,"Vegan", "Salad", 85.50, MenuType.Pizza, true, true, false);
Beverage B1 = new Beverage(3,"Beer","tuborg",15.00, MenuType.AlcoholicDrink, false, true, true);
Beverage B2 = new Beverage(4,"Soda","Cola, Fanta, Sprite", 20.00, MenuType.SoftDrink, false, true, false);
Sandwich S1 = new Sandwich(5,"Chicken Club", "Chicken, Tomato, lettuce", 55.00, MenuType.Sandwich, false, true, "Classic");
Sandwich S2 = new Sandwich(6,"Monster club", "mega sandwich", 150.50, MenuType.Sandwich, false, true, "Classic");

ItemCatalog ItemCatalog = new ItemCatalog();


Console.WriteLine("\tAdd items");
Console.WriteLine("\tShow items:");
ItemCatalog.Add(P1);
ItemCatalog.Add(P2);
ItemCatalog.Add(B1);
ItemCatalog.Add(B2);
ItemCatalog.Add(S1);
ItemCatalog.Add(S2);

ItemCatalog.PrintAll();

Console.WriteLine("\n\tDelete items");
Console.WriteLine("\tshow items after deleting");

ItemCatalog.Delete(B2);
ItemCatalog.Delete(S1);

ItemCatalog.PrintAll();

Console.WriteLine("\n\tVegan Pizzas");
List<IMenuItem>  veganItems= ItemCatalog.FindAllVegan(MenuType.Pizza);
ItemCatalog.PrintVegan(veganItems);

Console.WriteLine("\n\tOrganic Pizzas");
List<IMenuItem> organicItems = ItemCatalog.FindAllOrganic(MenuType.Pizza);
ItemCatalog.PrintOrganic(organicItems);

Console.WriteLine("\n\texpensive");
Console.WriteLine(ItemCatalog.MostExpensiveMenuItem().PrintInfo());


//Console.WriteLine(P1.PrintInfo());
//Console.WriteLine(B1.PrintInfo());
//Console.WriteLine(B2.PrintInfo());
//Console.WriteLine(S1.PrintInfo());