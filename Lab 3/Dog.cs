using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Dog : IAnimal
    {
        public string? Name
        {
            get; set;
        }
        public string? Colour
        {
            get; set;
        }
        public int Age
        { 
            get; set; 
        }
        public double Height
        {
            get; set;
        }
        public Dog() { }
        public Dog(string name, string colour, double height, int age) 
        { 
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
            this.Height = height;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public string Cry()
        {
            return "Woof!";
        }
    }
}
