using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johnosnW1Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing variables for later use
            String strFirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult;


            //Printing hello to the console and breaking to a new line
            Console.WriteLine("Hello There!");


            //Printing "Please enter your first name:" and recieving user input and storing it to strFirst on the same line in the console
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();

            //Printing "Hello " whatever the user entered for strFirst and "! Let's do some math!" to the console
            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");

            //Getting the first number the same way as strFirst and storing it to strNum1 as a string
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            //Getting the operand the same way as strFirst and storing it to strOperand as a string
            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine();

            //Getting the second number the same way as strFirst and storing it to strNum2 as a string
            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //parsing strNum1 for an int and storing it to intNum1
            intNum1 = Int32.Parse(strNum1);
            //converting strNum2 to an int and storing it to intNum2
            intNum2 = Convert.ToInt32(strNum2);


            //starting a switch statement for the strOperand
            switch (strOperand)
            {
                //if strOperand = "PLUS" it adds intNum1 and intNum2, stores it to intResult and breaks the switch statement
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                //if strOperand = "MINUS" it subtracts intNum1 and intNum2, stores it to intResult and breaks the switch statement
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                //if strOperand = "DIVIDE" it subtracts intNum1 and intNum2, stores it to intResult and breaks the switch statement
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
            }

            // casts intResult as a double ot dblResult
            dblResult = (Double)intResult;

            //Prints the proper output for the results of the math operation depending on wheather the user chose PLUS, MINUS or DIVIDE
            if(strOperand == "PLUS")
            {
                Console.WriteLine("\n\nThe sum of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
            }
            else if (strOperand == "MINUS")
            {
                Console.WriteLine($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            }
            else if (strOperand == "DIVIDE")
            {
                Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals:{dblResult}");
            }

            //Waits for the user to press a key so the program does not immediately end
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();

        }
    }
}
