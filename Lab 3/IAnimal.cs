using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface IAnimal
    {
        public abstract string? Name
        {
            get;
            set;
        }
        public abstract string? Colour
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
        public abstract double Height
        {
            get; 
            set;
        }

        abstract void Eat();
        abstract string Cry();
    }
}
