namespace Lesson04;

public class Button
{
    public delegate void ButtonDelegate(int id);
    
    event ButtonDelegate buttonClickDelegate;

    private int id;
    public Button(int id)
    {
        this.id = id;
    }

    public void Click()
    {
        buttonClickDelegate?.Invoke(id);
    }

    public void Subscribe(ButtonDelegate method)
    {
        buttonClickDelegate += method;
    }
    
    public void Unsubscribe(ButtonDelegate method)
    {
        buttonClickDelegate -= method;
    }
    
    public static void ClickMethod(int id)
    {
        Console.WriteLine("Clicked on button " + id);
    }
}