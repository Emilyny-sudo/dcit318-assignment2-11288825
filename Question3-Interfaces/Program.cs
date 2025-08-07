using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("The car drives on the road.");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("The bicycle is pedaled on the path.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();
    }
}
