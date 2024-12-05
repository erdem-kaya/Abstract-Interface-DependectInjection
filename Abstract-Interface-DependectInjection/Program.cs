using Abstract_Interface_DependectInjection;
using Abstract_Interface_DependectInjection.Interface;
using System;

namespace SolidConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cat sound

            IAnimal cat = new Cat();
            AnimalSound catSound = new AnimalSound(cat);
            catSound.MakeSound(); // Output: Meow


            // Dog sound

            IAnimal dog = new Dog();
            AnimalSound dogSound = new AnimalSound(dog);
            dogSound.MakeSound(); // Output: Hav Hav!


            Console.ReadKey();
        }
    }
}