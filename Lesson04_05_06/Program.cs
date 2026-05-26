// See https://aka.ms/new-console-template for more information

using Lesson04;

/*
Button b = new Button(202);
b.Subscribe(Button.ClickMethod);

Button b2 = new Button(444);
b2.Subscribe(Button.ClickMethod);

// could occur later in the game
b.Click();
b2.Click();
*/

Factory<Item> factory = new Factory<Item>();
Factory<Item>.Instance().Name = "sad";
Factory<Item>.Instance().Name = "ff";





//Calculator.Operation op = Calculator.Subtract;
//Console.WriteLine(op(10, 2, 3));
Inventory<string> string_inventory = new (5);
string_inventory[0] = "sword";
string_inventory[1] = "axe";

Inventory<int> int_inventory = new (3);
int_inventory[0] = 12130;

Inventory<Item> inventory = new (100);
Console.WriteLine("capacity = " + inventory.Capacity);
Console.WriteLine("count = " + inventory.Count);

Item newItem = new ();
newItem.Name = "axe";
inventory[0] =  newItem;

newItem = new ();
newItem.Name = "sword";
inventory[1] =  newItem;

//Item it = inventory["sword"];


//Console.WriteLine("count = " + inventory.Count);
//Console.WriteLine("count = " + inventory[0].Name);


//Console.WriteLine("item name = " + inventory[0]);

//Console.WriteLine(inventory);

List<Item> itemList = new();


foreach (var item in inventory)
{
   // if (item != null)
         Console.WriteLine(item);
}


/*
Console.WriteLine(inventory.Count.ToString());
Console.WriteLine(inventory[1].Name.ToString());
Console.WriteLine(inventory[2].Name.ToString());*/