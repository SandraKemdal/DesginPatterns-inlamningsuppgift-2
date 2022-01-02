using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
        public void Run()
        {
            AbstractFactory factory = new();
            IAnimalFactory dogFactory = factory.GetAnimalFactory("Dog");
            IAnimalFactory catFactory = factory.GetAnimalFactory("Cat");
            IAnimal dog = dogFactory.CreateAnimal("Jossi");
            IAnimal cat = catFactory.CreateAnimal("Palle");
            Console.WriteLine($"The dog's name is {dog.Name} and the cat's name is {cat.Name}");
           
        }
    }
}
