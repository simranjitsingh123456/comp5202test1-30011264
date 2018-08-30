using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_odd_or_even
{
    class Program
    {
        public static int Number1 { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a numder to find odd or even");
            Number1 = int.Parse(Console.ReadLine());
            if (Number1 % 1 == 0)
            {
                Console.WriteLine(" your even numder");


            }
            else (Number1 % 1 == 0)
            {
                Console.WriteLine(" your odd number");

            }
            Console.ReadLine();
        }
    }
}
