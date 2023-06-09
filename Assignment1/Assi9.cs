using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check whether a year is leap year or not 
namespace Assignment1
{
    internal class Assi9
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter Year:");
            year = Convert.ToInt32(Console.ReadLine());

            if((year % 4) == 0)
            {
                Console.WriteLine($"{year} is Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is Not Leap Year.");
            }
        }
    }
}
