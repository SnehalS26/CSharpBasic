using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a  program to enter P, T, R and calculate Compound Interest.
namespace Assignment1
{
    internal class Assi7
    {
        static void Main(string[] args)
        {
            int n, P, T, R;
            double CI;

            Console.WriteLine("Enter Value of n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Priciple amount:");
            P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Rate:");
            R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Time period:");
            T = Convert.ToInt32(Console.ReadLine());

            CI = P * (1 + R / n) ^ (n * T);
            Console.WriteLine("Compound Interest is :" + CI);
        }
    }
}
