
/*
    Lucas Johnson
    4/27/2021
    Private person class example
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnson_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("What is the person's first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("What is the person's middle name: ");
            person.MiddleName = Console.ReadLine();

            Console.Write("What is the person's last name: ");
            person.LastName = Console.ReadLine();

            Console.Write("What is the person's street 1: ");
            person.Street1 = Console.ReadLine();

            Console.Write("What is the person's street 2: ");
            person.Street2 = Console.ReadLine();

            Console.Write("What is the person's city: ");
            person.City = Console.ReadLine();

            Console.Write("What is the person's state: ");
            person.State = Console.ReadLine();

            Console.Write("What is the person's zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("What is the person's phone: ");
            person.Phone = Console.ReadLine();

            Console.Write("What is the person's email: ");
            person.Email = Console.ReadLine();

            Console.WriteLine("\n" + person.FirstName + "\n" + person.MiddleName + "\n" + person.LastName + "\n" + person.Street1 + "\n" + person.Street2 + "\n" + person.City + "\n" + person.State + "\n" + person.Zip + "\n" + person.Phone + "\n" + person.Email);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
