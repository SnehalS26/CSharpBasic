using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Accept two numbers & find the greater number.

namespace Assignment1
{
    internal class Assi4
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter 1st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("Greater number");
            }
            else
            {
                Console.WriteLine("Smaller number");
            }
        }
    }
}
