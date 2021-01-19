using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};
            Person niklas = new Niklas();
            niklas.SetName("Niklas");

            Console.WriteLine("###############");
            Console.WriteLine();

            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    animal.TransferOwnership(niklas._name);
                    
                }

                animal.Eat();
                animal.Sleep();
                animal.Speak();
                Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                Console.WriteLine();
                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
    }
}
