using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;

            //While
            while (total != 10)
            {
                Console.WriteLine(total);
                // reassigning the value of total to equal total + 1
                //total++;    or what we have below
                //total += 1;   // sets value of total + 1
                
                total = total + 1;
            }
            Console.WriteLine("");
            total = 0;
            //      condition is in parentheses.. just like all the syntax with Conditionals
            //      while loop will run until the condition == false
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    break;
                  
                }
                Console.WriteLine("somevalue");
                total++;

            }
            total++;   // this will take the value of total to 11... spinal tap or something
          //  Console.ReadLine();


            Random rand = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20); 

                if (someCount == 6 || someCount == 10) // 6 & 10 will not ever be written to the console
                {
                    continue;    // continue will disregard the rest of the loop, and will go back to the top to loop again
                }
                Console.WriteLine(someCount);

                if (someCount == 15)    //15 will only write to the console once
                {
                    keepLooping = false;
                }
            }
            Console.ReadLine();
        }
    }
}
