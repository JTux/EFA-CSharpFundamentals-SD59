using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ternaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 1;       //aka hardcoding in data

                        // condition   if true : if false
                        
            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine("Age is over 17: " + isAdult);

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            Console.WriteLine((numTwo == 30) ? "True" : "False");

            //Ternary functions are a way to write the if/else statement below in a more efficient manner
            if(numTwo == 30)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

           // Console.ReadLine();



            //function, Methods are function's that we define within a class... outside of a class it is just a function
            int DoubleValue(int parameter)
            {
                int doubleValue = parameter * 2;
                return doubleValue;
            }
            
            int TripleValue(int num)
            {
                return num * 3;
            }

            var banana = DoubleValue(127);
            //int orange = DoubleValue(7);
            //int pineapple = DoubleValue(17);
            //int apple = DoubleValue(1);


            
            int dataToManipulate = 5;
            Console.WriteLine(dataToManipulate);

            //int doubledValue = DoubleValue(dataToManipulate);
            //Console.WriteLine(doubledValue);

            string userInput = Console.ReadLine();
            int manipulatedData = (userInput == "double") ? DoubleValue(dataToManipulate) : TripleValue(dataToManipulate);

            Console.WriteLine(manipulatedData);

            Console.ReadLine();

        }
    }
}
