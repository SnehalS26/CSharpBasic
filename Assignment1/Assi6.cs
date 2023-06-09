using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program to enter marks of five subjects and calculate total, average and percentage
namespace Assignment1
{
    internal class Assi6
    {
        static void Main(string[] args)
        {
            int marathi, hindi, english, computer, science;

            Console.WriteLine("Enter Marathi Marks:");
            marathi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Hindi Marks:");
            hindi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter English Marks:");
            english = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Computer Marks:");
            computer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Science Marks:");
            science = Convert.ToInt32(Console.ReadLine());

            double avg, total, perc;

            total = marathi + hindi + english + computer + science;
            Console.WriteLine("Total Marks:" + total);

            avg = (total / 5);
            Console.WriteLine("Average Marks:" +avg);

            perc = (total /500) * 100;
            Console.WriteLine("Percentage is:" +perc);
        }
    }
}
