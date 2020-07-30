using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = true;

            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }
            //Console.ReadLine();

            int hoursSpentStudying = 17;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }
            //Console.ReadLine();

            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the Netflix!");
            }
            else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }


            //Console.WriteLine("How many hours did you sleep?");
            //string input = Console.ReadLine();
            //int totalHours = int.Parse(input);

            //if (totalHours >= 8)
            //{
            //    Console.WriteLine("You should be well rested.");
            //}
            //else
            //{
            //    Console.WriteLine("You might be tired today.");
            //    if (totalHours < 4)
            //    {
            //        Console.WriteLine("You should get more sleep!");
            //    }
            //}

            //Console.ReadLine();

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age < 0) //simple validation
            {
                Console.WriteLine("That's bad input, try again... wait you can't because we don't know what a loop is... stay tuned");
            }
            else
            {

                if (age > 17)
                {
                    Console.WriteLine("You're an adult.");
                }
                else
                {
                    if (age > 6)
                    {
                        Console.WriteLine("You're a kid.");
                    }
                    if (age > 0 && age <= 6)
                    {
                        Console.WriteLine("You're far too young to be on a computer");

                    }
                    else
                    {
                        Console.WriteLine("You're not born yet.");
                    }
                }
            }
            Console.ReadLine();

            if (age <= 65 && age >= 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }

            if (age >= 65 || age < 18)
            {
                Console.WriteLine("Age is either greater than 65 or less than 18");
            }

            if (age == 21)
            {
                Console.WriteLine(" Age is equal to 21.");
            }

            if (age != 36)
            {
                Console.WriteLine(" Age is not equal to 36.");
            }

            Console.ReadLine();
        }
    }
}
