using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");
            double number5 = 32.5;
            decimal number6 = 10.4m;
            char character = 'A';
            bool condition = true;
            int number1 = 2147483647;// 32 bit
            short number2 = 32767;// 16 bit
            long number3 = 9223372036854775807;// 64 bit
            byte number4 = 255; // 8 bit
            var number7 = 10;
            number7 = 'A';
       


            Console.WriteLine("number1 is {0}",number1);
            Console.WriteLine("number2 is {0}",number2);
            Console.WriteLine("number3 is {0}",number3);
            Console.WriteLine("number4 is {0}",number4);
            Console.WriteLine("character is: {0}", (int)character);
            Console.WriteLine("number5 is {0}",number5);
            Console.WriteLine("number6 is {0}", number6);
            Console.WriteLine("number7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
        enum Days
        {
            Monday=54,Tuesday,Wednesday,Thursday=64,Friday,Saturday,Sunday
        }
    }
}
