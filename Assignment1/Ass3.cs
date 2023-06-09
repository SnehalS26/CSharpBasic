using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Accept two angles of triangle and find third angle.

namespace Assignment1
{
    internal class Ass3
    {
        static void Main(string[] args)
        {
            int a, b , c , third_angle;

            Console.WriteLine("Enter 1st Value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine(c);
            third_angle = 180 - c;
            Console.WriteLine("Third Angle is:" +third_angle);


        }
    }
}
