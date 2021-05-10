using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnson_Lab0dot5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing variables for later use
            String first, operand;
            Double num1, num2, result = 0;

            //Printing hello to the console and breaking to a new line
            Console.WriteLine("Hello There!");


            //Printing "Please enter your first name:" and recieving user input and storing it to first on the same line in the console
            Console.Write("Please enter your first name: ");
            first = Console.ReadLine();

            //Printing "Hello " whatever the user entered for first and "! Let's do some math!" to the console
            Console.WriteLine("Hello " + first + "! Let's do some math!");

            //Getting the first number the same way as first and storing it to num1 as a string
            Console.Write("Please enter the first number: ");
            num1 = Double.Parse(Console.ReadLine());

            //Getting the operand the same way as first and storing it to operand as a string
            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            operand = Console.ReadLine().ToUpper();

            //Getting the second number the same way as first and storing it to num2 as a string
            Console.Write("Please enter the second number: ");
            num2 = Double.Parse(Console.ReadLine());

            


            //starting a switch statement for the operand
            switch (operand)
            {
                //if operand = "PLUS" it adds num1 and num2, stores it to result and breaks the switch statement
                case "PLUS":
                    result = num1 + num2;
                    break;
                //if operand = "MINUS" it subtracts num1 and num2, stores it to result and breaks the switch statement
                case "MINUS":
                    result = num1 - num2;
                    break;
                //if operand = "MULTIPLYT" it multiplies num1 and num2, stores it to result and breaks the switch statement
                case "MULTIPLY":
                    result = num1 * num2;
                    break;
                //if operand = "DIVIDE" it divides num1 and num2, stores it to result and breaks the switch statement
                case "DIVIDE":
                    result = num1 / num2;
                    break;
            }

            

            //Prints the proper output for the results of the math operation depending on wheather the user chose PLUS, MINUS or DIVIDE
            if (operand == "PLUS")
            {
                Console.WriteLine("\n\nThe sum of " + num1 + " and " + num2 + " equals " + result);
            }
            else if (operand == "MINUS")
            {
                Console.WriteLine($"\n\nThe sum of {num1} and {num2} equals {result}");
            }
            else if(operand == "MULTIPLY")
            {
                Console.WriteLine($"\n\nThe product of {num1} and {num2} equals {result}");
            }
            else if (operand == "DIVIDE")
            {
                Console.WriteLine($"\n\nThe quotient of {num1} and {num2} equals {result}");
            }

            //Waits for the user to press a key so the program does not immediately end
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();

        }
    }
}
