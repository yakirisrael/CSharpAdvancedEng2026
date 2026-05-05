// See https://aka.ms/new-console-template for more information

using Lesson03;

/*
Vector v1 = new Vector(1,2,3);
Vector v2 = new Vector(1,2,3);

Console.WriteLine("vector = " + v1.ToString());
Console.WriteLine("v1 equals v2? " + v1.Equals(v2));
Console.WriteLine("v1 hash code = " + v1.GetHashCode());
Console.WriteLine("v2 hash code = " + v2.GetHashCode());
*/

List<Cookable> grocerices = new List<Cookable>();
grocerices.Add(new ScrumbledEgg());
grocerices.Add(new Salad());


foreach (var food in grocerices)
{
    food.Cook();
}