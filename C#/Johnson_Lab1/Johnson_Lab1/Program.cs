/*
    Lucas Johnson
    4/2/2021
    Basic grade average calculator
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnson_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Double g1, g2, g3, g4, average;


            Console.Write("Enter a student's name: ");
            name = Console.ReadLine();

            Console.Write("\nEnter The first grade: ");
            g1 = Double.Parse(Console.ReadLine());

            Console.Write("\nEnter The second grade: ");
            g2 = Double.Parse(Console.ReadLine());

            Console.Write("\nEnter The third grade: ");
            g3 = Double.Parse(Console.ReadLine());

            Console.Write("\nEnter The fourth grade: ");
            g4 = Double.Parse(Console.ReadLine());

            average = (g1 + g2 + g3 + g4) / 4;
            
            if(average < 60)
            {
                Console.WriteLine($"\n{name} has a F average");
            }
            else if (average < 70)
            {
                Console.WriteLine($"\n{name} has a D average");
            }
            else if (average < 80)
            {
                Console.WriteLine($"\n{name} has a C average");
            }
            else if (average < 90)
            {
                Console.WriteLine($"\n{name} has a B average");
            }
            else if (average <= 100)
            {
                Console.WriteLine($"\n{name} has an A average");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
