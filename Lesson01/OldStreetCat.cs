namespace Lesson01;

public class OldStreetCat : StreetCat
{
    public OldStreetCat(string color) : base(color)
    {
        Console.WriteLine("Old Street Cat c'tor");
        
        base.Fight();
    }
}