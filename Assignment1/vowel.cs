using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
//Write a program to input any alphabet and check whether it is vowel or consonant 
namespace Assignment1
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter a Alphabets:");
            c = Convert.ToChar(Console.ReadLine());
            
            if(c == 'a' || c== 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'U' || c == 'O')
            {
                Console.WriteLine($"{c} is a Vowel.");
            }
            else if((c >= 'a' &&  c <= 'z') || (c >= 'A' && c <= 'Z'))
                    {
                Console.WriteLine($"{c} is a Consonant.");
                    }
            else
            {
                Console.WriteLine(" ");
            }


        }
    }
}
