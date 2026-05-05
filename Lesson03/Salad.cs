namespace Lesson03;

public class Salad : Cookable
{
    public void Cook()
    {
        Console.WriteLine("Slicing vegetables");
    }
    
    public void Eat()
    {
        Console.WriteLine("Eating salad");
    }
}