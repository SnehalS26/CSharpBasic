using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to find maximum between three numbers 
namespace Assignment1
{
    internal class MaxNo
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter 1st Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd Number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number 1st is Larger.");
                }
                else
                {
                    Console.WriteLine("Number 3rd is Larger.");
                }
            }
            else if(num2 > num3)
            {
                Console.WriteLine("Number 2nd is Larger.");
            }
            else
            {
                Console.WriteLine("Number 3rd is Larger.");

            }
        }
    }
}
