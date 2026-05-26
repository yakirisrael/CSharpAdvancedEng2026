namespace Lesson04;

public class Factory<T> where T : new()
{
    private static T instance;
    public static T Instance()
    {
        if (instance == null)
        {
            instance = new T();
        }
        return instance;
    }
}