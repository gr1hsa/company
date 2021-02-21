using System;

namespace FIbonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1, b = 1, c;
           for(int i = 0; i < 100; i++)
            {
                Console.Write(a + " ");
                c = a;
                a = b;
                b += c;
            }
        }
    }
}
