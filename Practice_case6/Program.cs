using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 number:");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double medium = (number1 + number2 + number3) / 3;
            Console.WriteLine($"Result: {medium}");
            Console.ReadKey();
        }
    }
}
