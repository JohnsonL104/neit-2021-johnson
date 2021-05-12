using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4SampleCode
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool blnResult = false;

            EBook temp = new EBook();

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
                DateTime tempDate;
                Console.Write("\nPlease enter the Date Published: ");
                blnResult = DateTime.TryParse(Console.ReadLine(), out tempDate);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect date format. Please try again. (EX: 10/31/2000) ");
                }
                else
                {
                    temp.DatePublished = tempDate;
                }
            } while (blnResult == false);


            do
            {
                Console.Write("\nPlease enter the number of pages: ");
                int tempPages;
                blnResult = Int32.TryParse(Console.ReadLine(), out tempPages);

                if (!blnResult)
                {
                    Console.Write("\nSorry incorrect page number. Please try again. (Ex: 362)");
                }
                else
                {
                    temp.Pages = tempPages;
                }

            } while (!blnResult);

            do
            {
                double tempPrice;
                Console.Write("\nPlease enter the Cost of the book: $");
                blnResult = Double.TryParse(Console.ReadLine(), out tempPrice);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect price. Please try again. (EX: 19.50)");
                }
                else
                {
                    temp.Price = tempPrice;
                }
            } while (blnResult == false);

            if (!temp.Feedback.Contains("ERROR:"))
            {
                Console.Write("\n\nWe Now Have the following book:");
                Console.Write($"\nTitle: {temp.Title}");
                Console.Write($"\nWritten By {temp.AuthorFirst} {temp.AuthorLast}");
                Console.Write($"\nEmail: {temp.Email}");
                Console.Write($"\nPublished: {temp.DatePublished.ToShortDateString()}");
                Console.Write($"\nPages: {temp.Pages}");
                Console.Write($"\nPrice: ${temp.Price}");

            }
            else
            {
                Console.WriteLine(temp.Feedback);
            }
            BasicTools.Pause();
        }
    }
}
