namespace Lesson04;

public class Calculator
{
    public delegate int Operation(int a, int b, int c);
    
    static public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }
    static public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
}