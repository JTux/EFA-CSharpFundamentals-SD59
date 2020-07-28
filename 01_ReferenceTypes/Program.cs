using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings
            string declared;
            declared = "This is assignment.";

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName);

            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            string interpolatedFullName = $"{firstName} {lastName}";
            string concatenatedFullName = firstName + " " + lastName;

            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);
            Console.WriteLine(concatenatedFullName);


            // Collections
            // Array
            string[] stringArray = { "Hello", "World", firstName, lastName };

            string thirdItem = stringArray[2];
            Console.WriteLine("The third item is " + thirdItem);

            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);


            // List
            string name = "Joshua";
            List<string> banana = new List<string>();
            List<string> orange = banana;

            banana.Add("Hello there");

            Queue<int> firstInFirstOut = new Queue<int>();
            firstInFirstOut.Enqueue(37);
            int output = firstInFirstOut.Dequeue();

            Stack<int> firstInLastOut = new Stack<int>();

            Dictionary<string, List<string>> keyAndValue = new Dictionary<string, List<string>>();
            keyAndValue.Add("Instructor", banana);
            Console.WriteLine("Your instructor is " + keyAndValue["Instructor"]);

            Console.ReadLine();
        }
    }
}
