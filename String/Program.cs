using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();


        }

        public static void Intro()
        {

            string city = "Muğla";
            // Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Ankara";

            Console.WriteLine(string.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
