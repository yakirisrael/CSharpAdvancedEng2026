// See https://aka.ms/new-console-template for more information

using Lesson01;

int maxFloor = 10;
Elevator e = new Elevator(maxFloor);

e.MoveToFloor(3);

Console.WriteLine("---------------------");
ShabatElevator shabat = new ShabatElevator(maxFloor);
shabat.Move();