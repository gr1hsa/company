using System;
using System.Collections.Generic;

namespace lfmfsdfsd
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            while (true)
            {

                a = Double.Parse(Console.ReadLine());
                b = Double.Parse(Console.ReadLine());
                c = Double.Parse(Console.ReadLine());
                d = Double.Parse(Console.ReadLine());
                Console.WriteLine("x^3: " + (-3 * a + 3 * b + c - d) / 6 + " " + (-3 * a + 3 * b + c - d) % 6 + "///////     " + (-3 * a) + " " + 3 * b + " " + c + " " + (-d));
                Console.WriteLine("x^2: " + (-2 * a + b + c) / 2 + " " + (-2 * a + b + c) % 2 + "/////        " + (-2 * a) + " " + b + " " + c);
                Console.WriteLine("x: " + (3 * a - 6 * b + 2 * c + d) / 6 + " " + (3 * a - 6 * b + 2 * c + d) % 6 + "   /////////   " + 3 * a + " " + (-6 * b) + " " + 2 * c + " " + d);
                Console.WriteLine(" :  " + a);

            }


        }
    }
}
