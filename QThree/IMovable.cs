using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//define new interface
public interface IMovable
{
    void Move();
}

//Car class that is extending the IMovable interface
public class Car : IMovable
{
    //a method that is implementing the Move method in IMovable
    public void Move()
    {
        Console.WriteLine("\t\t\tCar is moving\n");
    }
}


//Bicycle class that is extending the IMovable interface
public class Bicycle : IMovable
{
    //a method that is implementing the Move method in IMovable
    public void Move()
    {
        Console.WriteLine("\t\t\tBicycle is moving");
    }
}