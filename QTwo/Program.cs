public class Program
{
   static void Main(string[] args)
   {
        //take the radius of a circle from user
        Console.Write("\t\tPlease enter the radius of a circle\n");
        double radius = Convert.ToDouble(Console.ReadLine());

        //take the length of a rectangle from user
        Console.Write("\t\tPlease enter the length of a rectangle\n");
        double length = Convert.ToDouble(Console.ReadLine());


        //take the width of a rectangle from user
        Console.Write("\t\tPlease enter the width of a rectangle\n");
        double width = Convert.ToDouble(Console.ReadLine());

        //call classes and create instances
        Shape circle = new Circle(radius);
        Shape rectangle = new Rectangle(length, width);

        //print results
        Console.WriteLine($"\n\t\tArea of the circle: {circle.getArea()} squared units");
        Console.WriteLine($"\n\t\tArea of the rectangle: {rectangle.getArea()} squared units");
    }
}
