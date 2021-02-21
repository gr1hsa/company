using System;

namespace f_abfgkauhfs
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            while (true)
            {
                string s = Console.ReadLine();
                k += s.Length;
                Console.WriteLine(k);
            }
        }
    }
}
