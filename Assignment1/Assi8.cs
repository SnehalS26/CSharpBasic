using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
//Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
namespace Assignment1
{
    internal class Assi8
    {
        static void Main(string[] args)
        {
            double Fahrenheit, celsius;

            Console.WriteLine("Enter Temperature in Celsius:");
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Temperature in Fahrenheit:");
            Fahrenheit = Convert.ToInt32(Console.ReadLine());

            Fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("Celsius To Fahrenheit is:" +Fahrenheit);

            celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit To Celsius is:" +celsius);
        }
    }
}
