using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result;
            string operation;

            Console.WriteLine("...... Welcome to the Calculator.....");

            Console.WriteLine("Enter your first number : ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number : ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What type of operation you whould like to do : ");
            Console.WriteLine("Enter 'a' for addition, 's' for substraction, 'd' for divition, 'm' for multiplication ");
            operation = Console.ReadLine().ToLower();

            if (operation == "a")
            {
                result = num1 + num2;
            }
            else if (operation == "s")
            {
                result = num1 - num2;
            }
            else if (operation == "d")
            {
                result = num2 == 0? float.NaN : num1 / num2;
            }
            else if (operation == "m")
            {
                result = num1 * num2;
            }
            else
            {
                Console.WriteLine("Incorrect Input");
                return;

            }

            if (float.IsNaN(result))
            {
                Console.WriteLine("Can not divide by zero");
            } else
            {
                Console.WriteLine("Answer is : " + result);
            }

            Console.WriteLine("...Thank you for using calculator...");
        }
    }
}
