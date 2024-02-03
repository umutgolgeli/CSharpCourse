using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();


            if (IsPrimeNumber(7)) {
                Console.WriteLine("This is a prime number");
            }
            else {
                Console.WriteLine("This is not a prime number");
                    }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number) {
            bool result = true;
            for (int i = 2; number < i - 1; i++) {
                if (number % i == 0) { 
                    result = false;
                    
                }
            }return result;
        }

        private static void ForEachLoop() {
            string[] students2 = new[] { "Engin", "Salih", "Duru" };
            foreach (var student in students2) { 
                Console.WriteLine(student);
            }Console.ReadLine();

        }


        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 1);
            Console.ReadLine();


        }

        private static void WhileLoop()
        { 
        int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
    Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();
        }



        private static void ForLoop() { 
            for(int i = 0; i< 50; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("finished");
            Console.ReadLine();
        }

    }
}
