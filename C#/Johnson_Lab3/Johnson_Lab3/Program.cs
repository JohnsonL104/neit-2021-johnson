/*
    Lucas Johnson
    4/19/2021
    Multi student grade average calculator
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnson_Lab2
{
    class Program
    {


        static void Main(string[] args)
        {
            String numStudentsStr;
            Int32 numStudentsInt;

            //defnie two dimensional array that will hold students name and grades as strings to be parsed for doubles later to allow for multiple student entry that will be layed out as so: 
            //{
            //  { "student 1's name", "student 1's first grade", "student 1's second grade", "student 1's third grade", "student 1's fourth grade", "student 1's fith grade"},
            //  { "student 2's name", "student 2's first grade", "student 2's second grade", "student 2's third grade", "student 2's fourth grade", "student 2's fith grade"}
            //}  

            String[,] grades;

            //Determine how many students the user would like to enter and defining the dimensions of the array
            Console.Write("How many students would you like to enter: ");
            numStudentsStr = Console.ReadLine();
            while (!Int32.TryParse(numStudentsStr, out numStudentsInt))
            {
                Console.Write("\nInvalid Input Try Again(Input must be an integer)\n\nHow many students would you like to enter: ");
                numStudentsStr = Console.ReadLine();
            }
            grades = new String[numStudentsInt, 6];


            //Populate grades array with student's names and grades
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Int32 tempInt;
                String tempStr;
                Console.Write("\nEnter Student " + (i + 1) + "'s Name: ");
                grades[i, 0] = Console.ReadLine();

                for (int y = 1; y < grades.GetLength(1); y++)
                {
                    switch (y)
                    {
                        case 1:
                            Console.Write("\nEnter Student " + (i + 1) + "'s first grade: ");
                            break;
                        case 2:
                            Console.Write("\nEnter Student " + (i + 1) + "'s second grade: ");
                            break;
                        case 3:
                            Console.Write("\nEnter Student " + (i + 1) + "'s third grade: ");
                            break;
                        case 4:
                            Console.Write("\nEnter Student " + (i + 1) + "'s fourth grade: ");
                            break;
                        case 5:
                            Console.Write("\nEnter Student " + (i + 1) + "'s fith grade: ");
                            break;
                    }

                    tempStr = Console.ReadLine();
                    while (!Int32.TryParse(tempStr, out tempInt))
                    {
                        switch (y)
                        {
                            case 1:
                                Console.Write("\nInvalid Input Try Again(Input must be an integer)\n\nEnter Student " + (i + 1) + "'s first grade: ");
                                break;
                            case 2:
                                Console.Write("\nInvalid Input Try Again(Input must be an integer)\n\nEnter Student " + (i + 1) + "'s second grade: ");
                                break;
                            case 3:
                                Console.Write("\nInvalid Input Try Again(Input must be an integer)\n\nEnter Student " + (i + 1) + "'s third grade: ");
                                break;
                            case 4:
                                Console.Write("\nInvalid Input Try Again(Input must be an integer)\n\nEnter Student " + (i + 1) + "'s fourth grade: ");
                                break;
                            case 5:
                                Console.Write("\nInvalid Input Try Again(Input must be an integer)\n\nEnter Student " + (i + 1) + "'s fith grade: ");
                                break;
                        }
                        tempStr = Console.ReadLine();
                    }
                    grades[i, y] = tempStr;

                }
            }

            //Outputing each student and their average and letter grade
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Double tempAvg = getAvg(grades, i);
                if (tempAvg < 60)
                {
                    printGrade(grades[i, 0], "F", tempAvg);
                }
                else if (tempAvg < 70)
                {
                    printGrade(grades[i, 0], "D", tempAvg);
                }
                else if (tempAvg < 80)
                {
                    printGrade(grades[i, 0], "C", tempAvg);
                }
                else if (tempAvg < 90)
                {
                    printGrade(grades[i, 0], "B", tempAvg);
                }
                else
                {
                    printGrade(grades[i, 0], "A", tempAvg);
                }

            }

            //Outputing everyones average for each lab
            for (int i = 1; i < grades.GetLength(1); i++)
            {
                Double tempDbl = 0;
                for (int y = 0; y < grades.GetLength(0); y++)
                {
                    tempDbl += Double.Parse(grades[y, i]);
                }
                Console.WriteLine("\nThe total average for Lab " + i + " is " + (tempDbl / grades.GetLength(0)));
            }

            waitForUser();
        }

        static void waitForUser()
        {
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }
        static Double getAvg(String[,] list, Int32 index){
            Double tempDouble = 0;
            int i;
            for(i = 1; i < list.GetLength(1); i++)
            {
                tempDouble += Double.Parse(list[index, i]);
            }
            return Math.Round(tempDouble / (i-1));
        }

        static void printGrade(String name, String grade, Double avg)
        {
            Console.WriteLine("\n" + name + "'s Average Grade is: " + avg + " which is a " + grade);
        }
    }
}
