// See https://aka.ms/new-console-template for more information

using Lesson04;

Inventory inventory = new (100);
Console.WriteLine("capacity = " + inventory.Capacity);
Console.WriteLine("count = " + inventory.Count);
Item newItem = new ();
newItem.Name = "axe";
inventory[0] =  newItem;



Console.WriteLine("count = " + inventory.Count);
Console.WriteLine("count = " + inventory[0].Name);

Item it = inventory["sword"];
Console.WriteLine("item name = " + it.Name);


/*
Console.WriteLine(inventory.Count.ToString());
Console.WriteLine(inventory[1].Name.ToString());
Console.WriteLine(inventory[2].Name.ToString());*/