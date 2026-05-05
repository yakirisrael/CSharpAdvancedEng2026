namespace Lesson01;

public class Cat
{
    protected string color = "";

    public Cat()
    {
        Console.WriteLine("Cat default c'tor");
    }

    public Cat(string color)
    {
        this.color  = color;
        Console.WriteLine("Cat with paramters c'tor");
    }
    private void Voice()
    {
        Console.WriteLine("Meow");
    }
}