using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            //Add();
            //var result = Sum();
            //int number1 = 20;
            //int number2 = 100;
            // var result = Add2(ref number1,number2);
            // Console.WriteLine(result);
            // Console.WriteLine(number1);

            // Console.WriteLine(multiply(2,4,5));

            int result = Multiply(2, 3, 4); 
            Console.WriteLine(result); 

            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Sum(int num1=30, int num2=40 ) {
            var result = num1 + num2;
            return result;
        }

        static int Add2(ref int number1, int number2 ) {
            number1 = 30;
            return number1 + number2;
       
        }
        static int multiply(int number1, int number2, int number3) {
            return number1 * number2 * number3;
        }

        static int Multiply(params int[] numbers)
        {
            int result = 1;
            foreach (int number in numbers)
            {
                result *= number;
            }
            return result;
        }



    }
}
