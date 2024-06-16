using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public class Animal
  {
    public virtual void MakeSound()
    {
        Console.WriteLine("\t\tSome generic sound");
    }
  }


public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("\t\tBark");
    }
}


public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("\t\tMeow");
    }
}