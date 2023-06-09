using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to check whether a number is divisible by 5 and 11 or no
namespace Assignment1
{
    internal class Assi10
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the Value:");
            a = Convert.ToInt32(Console.ReadLine());

            if(a%5 == 0 && a%11 == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }
        }
    }
}
