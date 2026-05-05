namespace Lesson01;

public class ShabatElevator : Elevator
{
    public ShabatElevator(int maxFloor) : base(maxFloor)
    {
    }

    public void Move()
    {
        for (int i = 1; i <= maxFloor; i++)
            MoveToFloor(i);
    }
}