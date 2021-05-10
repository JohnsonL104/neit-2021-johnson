using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4SampleCode
{
    class Program
    {
        struct Book
        {
            public string Title;
            public string AuthorFirst;
            public string AuthorLast;
            public string Email;
            public DateTime DatePublished;
            public int Pages;
            public double Price;

        }
        static void Main(string[] args)
        {
            bool blnResult = false;

            Book temp = new Book();

            Console.Write("\nPlease enter the title: ");
            temp.Title = Console.ReadLine();

            Console.Write("\nPlease enter the Author's First Name: ");
            temp.AuthorFirst = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Last name: ");
            temp.AuthorLast = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Email: ");
            temp.Email = Console.ReadLine();

            do
            {
                Console.Write("\nPlease enter the Date Published: ");
                blnResult = DateTime.TryParse(Console.ReadLine(), out temp.DatePublished);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect date format. Please try again. (EX: 10/31/2000) ");
                }
            } while (blnResult == false);

            do
            {
                Console.Write("\nPlease enter the Cost of the book: $");
                blnResult = Double.TryParse(Console.ReadLine(), out temp.Price);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect price. Please try again. (EX: 19.50)");
                }
            } while (blnResult == false);


            Console.Write("\n\nWe Now Have the following book:");
            Console.Write($"\nTitle: {temp.Title}");
            Console.Write($"\nWritten By {temp.AuthorFirst} {temp.AuthorLast}");
            Console.Write($"\nEmail: {temp.Email}");
            Console.Write($"\nPublished: {temp.DatePublished.ToShortDateString()}");
            Console.Write($"\nPages: {temp.Pages}");
            Console.Write($"\nPrice: ${temp.Price}");

            BasicTools.Pause();
        }
    }
}
