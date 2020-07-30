using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {                            //If Else ==>       // If this conditional is true or false, then run this code. 
                                 // Switch Cases ==> // When this conditional is "Whatever we decide", then run this code.
        static void Main(string[] args)
        {
            int input = 2;


            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");              
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case is evaluated as true. Defaults are not required");
                    break;
            }


            DayOfWeek today = DateTime.Today.DayOfWeek;
            DayOfWeek monday = DayOfWeek.Monday;
            switch (monday)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Oh jeez, another Monday");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    
                case DayOfWeek.Friday:
                    Console.WriteLine("It's a weekday");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;
            }


            Console.ReadLine();

            //-- Challenge
            // Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response for each value. If they respond out of range, let them know.





        }
    }
}
