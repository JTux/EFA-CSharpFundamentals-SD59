using System;
using System.Collections.Generic;
using _09_Interfaces_Introduction.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_Introduction
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            //Arrange
            IFruit banana = new Banana();

            //Act
            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.Peeled);

            //Assert
            Assert.IsTrue(banana.Peeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            //Arrange
            var orange = new Orange();

            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                orange
            };

            //Act
            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                Console.WriteLine();

                //Assert
                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Console.WriteLine(orange.Squeeze());
            //Assert
            Assert.IsInstanceOfType(orange, typeof(Orange));

        }

        private string GetFruitName(IFruit fruit)
        {
            
            return $"This fruit is called {fruit.Name}.";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            var output = GetFruitName(grape);

            Console.WriteLine(output);

            Assert.IsTrue(output.Contains("This fruit is called Grape."));

        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            Console.WriteLine();
            
            foreach (var fruit in fruitSalad)
            {       // if fruit is an Orange, create a new instance of Orange called orange
                if(fruit is Orange orange)
                {
                    if (orange.Peeled)
                    {
                        Console.WriteLine("Is a peeled Orange.");
                        orange.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("Is an Orange.");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Is a Grape.");
                }
                else if (fruit.Peeled)
                {
                    Console.WriteLine("Is a peeled Banana.");
                }
                else
                {
                    Console.WriteLine("Is a Banana.");
                }

            }

        }
        
    }
}
