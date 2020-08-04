using System;
using System.Collections.Generic;
using _07_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance_Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void ConstructorTests()
        {
            Animal casey = new Animal();
            casey.Move();

            Console.WriteLine();

            Cat mittens = new Cat();
            mittens.Move();
            mittens.MakeSound();

            Console.WriteLine();

            Cat content = new Liger();
            content.Move();
            content.MakeSound();

            Liger garfield = (Liger)content;
            garfield.TeethSize = "Kinda large";

            Console.WriteLine();

            Liger billyJoel = new Liger();
            billyJoel.Move();
            billyJoel.MakeSound();

            billyJoel.TeethSize = "Reeallly big.";
        }

        [TestMethod]
        public void CheckingTypes()
        {
            Liger mittens = new Liger();

            List<Animal> animals = new List<Animal>();

            animals.Add(mittens);
            animals.Add(new Cat());
            animals.Add(new Animal());

            foreach (var animal in animals)
            {
                animal.Move();
            }
        }
    }
}
