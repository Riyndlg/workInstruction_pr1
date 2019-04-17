using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case7
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double r;
            double area;
            Console.Write("Enter value for R: ");
            r = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(r, 2);
        }
    }
}
