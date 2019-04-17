using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case8
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double r, h, v, s;
            Console.Write("Enter value for R: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Enter value for h: ");
            h = double.Parse(Console.ReadLine());
            v = pi * h * Math.Pow(r, 2);
            s = 2 * pi * r * (h + r);
            Console.Write($"Results: volume: {v}, area: {s}");
            Console.ReadKey();
        }
    }
}
