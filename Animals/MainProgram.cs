using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Animals
{
    class MainProgram
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Kitten("Murda", 8),
                new Tomcat("Marlio", 5),
                new Tomcat("Svetlio", 4),
                new Frog("Darvesna", 2, "female"),
                new Frog("Blatna", 4, "female"),
                new Dog("ELiza", 2, "female"),
                new Dog("Bobi", 8, "male"),
                new Dog("Zerg", 3, "male")
            };

            var catAverage = animals.Where(animal => animal is Cat).Average(x => x.Age);
            var dogAverage = animals.Where(animal => animal is Dog).Average(x => x.Age);
            var frogAverage = animals.Where(animal => animal is Frog).Average(x => x.Age);
            var tomcatAverage = animals.Where(animal => animal is Tomcat).Average(x => x.Age);
            var kittenAverage = animals.Where(animal => animal is Kitten).Average(x => x.Age);

            //  Console.WriteLine(frogAverage);
            Console.WriteLine("Cats - {0,5:F2}\nDogs - {1,5:F2}\nFrogs - {2,5:F2}\nTomcats - {3,5:F2}\nKittens - {4,5:F2}",
                                                    catAverage, dogAverage, frogAverage, tomcatAverage, kittenAverage);

            animals[3].ProduceSound();
        }
    }
}
