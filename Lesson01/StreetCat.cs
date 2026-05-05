namespace Lesson01;

public class StreetCat : Cat
{
    public StreetCat(string color) : base(color)
    {
        Console.WriteLine("Street Cat c'tor");
       
    }

    public void Fight()
    {
        Console.WriteLine("Fight");
    }
}