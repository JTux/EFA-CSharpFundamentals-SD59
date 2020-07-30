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
            Console.WriteLine();
            Console.WriteLine(); // just to break up the code for the terminal
            Console.WriteLine();

            int studentCount = 21;

            // 1 Starting Point
            // 2 While this condition is true, keep looping
            // 3 What we do after each iteration/loop
            // 4 Code we execute each iteration/loop
         // for    // 1      // 2 (condition)    //3
            for (int counter = 0; counter < studentCount; counter++)
            {
                //4 code to execute
                Console.WriteLine(counter);
            }

            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(); // just to break up the code for the terminal
            Console.WriteLine();
                    //             [0]      [1]         [2]
            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg", "Michael", "Marquese", "Kevin", "Casey" };
                    //1         //2 (condition)   //3
            for ( int i = 0; i < students.Length; i++)
            {                                 // the i'th index of our array, it will return the value of that index
                Console.WriteLine($"Welcome to class {students[i]}!");
            }

            Console.WriteLine();
            Console.WriteLine(); // just to break up the code for the terminal
            Console.WriteLine();


            //1 Collection being worked on
            //2 Name of the current iteration
            //3 Type in the collection
            //4 in keyword used to seperate the individual and the collection
            //        //3    //2   //4  //1
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class... or are they Instructors??");
            }
           // Console.ReadLine();

            // We are now iterating through a student's name
            string oneStudent = students[2];
            foreach (char letter in oneStudent)
            {
                Console.WriteLine(letter + " is a letter in my name");
            }
            //Console.ReadLine();

            string myName = "Casey Michael Wilson";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
            //Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(); // just to break up the code for the terminal
            Console.WriteLine();

            //Do While Loop             -- Do something once, and then continue to do that while the condition is true

            //While Loop is a Pre-Test, meaning it will test the conditional for true/false before first iteration
            //Do While Loop is a Post-Test, it will run 1 iteration and then test the conditional for true/false before continuing to the next iteration

            int iterator = 0;
            do
            {   // we will run this code once, and then keep running it until our condition is false
                Console.WriteLine("Hello!");
                iterator++;
            }
                    //condition
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            } 
            while (false);

            Console.ReadLine();
        }
    }
}
