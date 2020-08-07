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
                //Assert
                Assert.IsInstanceOfType(fruit, typeof(IFruit));
                
            }

            Console.WriteLine(orange.Squeeze());
            //Assert
            Assert.IsInstanceOfType(orange, typeof(Orange));

        }
    }
}
