using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Accept length and breadth of a rectangle and find perimeter.
namespace Assignment1
{
    internal class Ass2
    {
        static void Main(string[] args)
        {
            int l, b, p;

            Console.WriteLine("Enter Length of Rectangle:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle:");
            b = Convert.ToInt32(Console.ReadLine());

            p = 2 * (l + b);

            Console.WriteLine("Perimeter is:" + p);

        }
    }
}
