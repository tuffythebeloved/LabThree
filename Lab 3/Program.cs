using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            Console.WriteLine("Please name your dog.");
            string dogName = Console.ReadLine();

            Dog dog = new Dog(dogName, "Brown", 2);

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Age);
            dog.Eat();

            Console.WriteLine("Please name your cat.");
            string catName = Console.ReadLine();

            Cat cat = new Cat(catName, "Orange", 4);

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Age);
            cat.Eat();
            **/

            Console.WriteLine("Please name your dog.");
            string dogName = Console.ReadLine();

            Console.WriteLine("What is your dogs colour?");
            string dogColour = Console.ReadLine();

            Console.WriteLine("What is your dogs height?");
            string dogHeight = Console.ReadLine();

            Console.WriteLine("What is your dogs Age?");
            string dogAge = Console.ReadLine();

            Dog dog = new Dog(dogName, dogColour, double.Parse(dogHeight), int.Parse(dogAge));

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Height);
            Console.WriteLine(dog.Age);
            dog.Eat();
            Console.WriteLine(dog.Cry());

            Console.WriteLine("Please name your cat.");
            string catName = Console.ReadLine();

            Console.WriteLine("What is your cats colour?");
            string catColour = Console.ReadLine();

            Console.WriteLine("What is your cats height?");
            string catHeight = Console.ReadLine();

            Console.WriteLine("What is your cats Age?");
            string catAge = Console.ReadLine();

            Cat cat = new Cat(catName, catColour, double.Parse(catHeight), int.Parse(catAge));

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Age);
            cat.Eat();
            Console.WriteLine(cat.Cry());

            List<IAnimal> list = new List<IAnimal>();
            list.Add(dog);
            list.Add(cat);

            foreach(IAnimal animal in list)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
