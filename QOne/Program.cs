public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tQuestion One\n");

            //Call classes
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }