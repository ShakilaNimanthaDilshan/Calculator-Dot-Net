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

            Console.WriteLine("...... Welcome to the Calculator.....");

            Console.WriteLine("Enter your first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
