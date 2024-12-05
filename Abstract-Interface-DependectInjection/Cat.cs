using Abstract_Interface_DependectInjection.Interface;

namespace Abstract_Interface_DependectInjection
{
    public class Cat : IAnimal
    {
        public void SoundOutput()
        {
            System.Console.WriteLine("Meow");
        }
    }
}
