using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to calculate area of an equilateral triangle.
namespace Assignment1
{
    internal class Assi5
    {
        static void Main(string[] args)
        {
            double a, A;

            Console.WriteLine("Enter Value of a:");
            a = Convert.ToDouble(Console.ReadLine());

            A = (1.73 / 4) * a * a;
            Console.WriteLine("The Area of Equilateral triangle:" +A);
        }
    }
}
