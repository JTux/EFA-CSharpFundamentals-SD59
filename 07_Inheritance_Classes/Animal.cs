using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance_Classes
{
    public enum DietType { Herbivore, Omnivore, Carnivore }
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("This is the Animal Constructor.");
        }

        public int LegCount { get; set; }
        public bool IsMammal { get; set; }
        public bool HasTail { get; set; }
        public DietType TypeOfDiet { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
