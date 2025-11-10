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
            int num1;
            int num2;
            string operation;
            int result;

            Console.WriteLine("...... Welcome to the Calculator.....");

            Console.WriteLine("Enter your first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation you whould like to do : ");
            Console.WriteLine("Enter 'a' for addition, 's' for substraction, 'd' for divition, 'm' for multiplication ");
            operation = Console.ReadLine();

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
                result = num1 / num2;
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

            Console.WriteLine("Answer is : " + result);
        }
    }
}
