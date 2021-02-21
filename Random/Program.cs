using System;
using System.Collections.Generic;
using System.IO;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            List<int> a = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10000000; i++)
            {   
               
                a.Add(rnd.Next(0, 100000));
            }
            for(int i = 0; i < 10; i++)
                Console.WriteLine(a[i]);
           
                using (var sw = new StreamWriter("Random123.txt"))
                {

                    while (k < a.Count)
                    {
                        sw.WriteLine(a[k]);
                    k++;
                    }
                }
            }
    }
}
