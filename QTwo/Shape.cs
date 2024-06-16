using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//abstract shape class
public abstract class Shape
 {
    public abstract double getArea();
 }


//Derived Circle class
public class Circle : Shape
{
    private double radius;

    //Contructor method;
    public Circle(double radius)
    {
        this.radius = radius;
    }

    //override the abstract method
    public override double getArea()
    {
        //return area of a curcle
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    //dimensions of a rectangle
    private double length;
    public double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    //override the abstract method
    public override double getArea()
    {
        //return the area of a circle
        return length * width;
    }
}