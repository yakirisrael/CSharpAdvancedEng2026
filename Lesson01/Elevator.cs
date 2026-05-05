namespace Lesson01;

public class Elevator
{
    protected int maxFloor;
    protected int currentFloor;

    public Elevator(int maxFloor)
    {
        this.maxFloor = maxFloor;
        this.currentFloor = 1;
    }

    public void MoveToFloor(int floor)
    {
        if (floor > this.maxFloor || floor < 1)
            return;
        
        this.currentFloor = floor;
        PrintCurrentFloor();
    }

    public void PrintCurrentFloor()
    {
        Console.WriteLine(this.currentFloor);
    }

}