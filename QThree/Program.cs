public class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine("\t\t\t>>>Question Three<<<\n\n\n");

        //call classes and instances
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        //call methods
        car.Move();
        bicycle.Move();
   }
}