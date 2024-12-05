

using Abstract_Interface_DependectInjection.Interface;

namespace Abstract_Interface_DependectInjection
{
    public class Dog : IAnimal
    {
        public void SoundOutput()
        {
            System.Console.WriteLine("Hav Hav!");
        }
    }
}
