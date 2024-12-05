
using Abstract_Interface_DependectInjection.Interface;

namespace Abstract_Interface_DependectInjection
{
    public class AnimalSound
    {
        private readonly IAnimal _animal;

        public AnimalSound(IAnimal animal)
        {
            _animal = animal;
        }

        public void MakeSound()
        {
            _animal.SoundOutput();
        }
    }
}
