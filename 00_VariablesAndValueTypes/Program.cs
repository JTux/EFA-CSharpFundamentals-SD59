using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Booleans
            // Declaration - type name;
            bool isDeclared;

            // Assigning a value
            isDeclared = true;

            // Declaring and assigning an initial value
            bool isDeclarationAndInitialized = false;

            isDeclarationAndInitialized = true;


            // Characters
            char letter = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';

            Console.WriteLine(number / 5);


            // Whole Numbers
            byte byteExample = 255;
            sbyte signedByte = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = -32000;
            int intMin = -2147483648;
            uint unsignedInt = 4000000000;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;

            Console.WriteLine(longExample + 1);

            // Decimals
            float floatExample = 2147483641.320561408513f;
            double doubleExample = 2147483641.320561408513d;
            decimal decimalExample = 2147483641.320561408513m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);


            // Structs
            DateTime today = DateTime.Today;
            DateTime tomorrow = new DateTime(2020, 7, 28);


            // Enums
            PastryType myPastry = PastryType.Cake;
            PastryType anotherOne = PastryType.Eclaire;

            DayOfWeek dayOfWeek = DayOfWeek.Tuesday;

            Console.ReadLine();
        }
    }

    enum PastryType { Cake, Cupcake, Eclaire }
}
