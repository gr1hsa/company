using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace L1nkedL1st
{   

    
    class Program
    {
        public static List<int> Plus(List<int> a, List<int> b)
        {
            for (int i = 0; i < b.Count; i++)
                a.Add(b[i]);
            return a;
        }
        public static List<int> Quick(List<int> a)
        {
            
            if (a.Count > 1)
           {
                Random rnd = new Random();
                int r = rnd.Next(0, a.Count - 1);
                int r1 = rnd.Next(0, a.Count - 1);
                int r2 = rnd.Next(0, a.Count - 1);
                r = a[r];
                r1 = a[r1];
                r2 = a[r2];
                r = r1 + r2 + r - Math.Min(r1, Math.Min(r, r2)) - Math.Max(r1, Math.Max(r, r2));
                List<int> left = new List<int>();
                List<int> mid = new List<int>();
                List<int> right = new List<int>();
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] < r)
                        left.Add(a[i]);
                    else if (a[i] == r)
                        mid.Add(a[i]);
                    else
                        right.Add(a[i]);
                }

                return Plus(Plus(Quick(left), mid), Quick(right));
            }
            else
                return a;
        }
        static void Main(string[] args)
        {
            /*MyLinkedList<int> qq = new MyLinkedList<int>(10);
            using (var sr = new StreamReader(@"C:\Users\гришша\source\repos\company\Random\bin\Debug\netcoreapp3.1\Random123.txt"))
            {
                string a = sr.ReadLine();
                qq.AddLast(int.Parse(a));
                qq.RemoveFirst();
                while ((a = sr.ReadLine()) != null)
                    qq.AddLast(int.Parse(a));
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();            
            qq.QuickSort(0, qq.Count);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts.Minutes + " " + ts.Seconds + " " + ts.Milliseconds);*/
            /*using (var sr = new StreamReader(@"C:\Users\гришша\source\repos\company\Random\bin\Debug\netcoreapp3.1\Random123.txt"))
            {
                string a = sr.ReadLine();
                qq.AddLast(int.Parse(a));
                qq.RemoveFirst();
                while ((a = sr.ReadLine()) != null)
                    qq.AddLast(int.Parse(a));
            }
            stopWatch.Start();
            qq.BubbleSort();
            stopWatch.Stop();
            TimeSpan ps = stopWatch.Elapsed;
            Console.WriteLine(ps.Minutes + " " + ps.Seconds + " " + ps.Milliseconds);*/
            List<int> b = new List<int>();
            using (var sr = new StreamReader(@"C:\Users\гришша\source\repos\company\Random\bin\Debug\netcoreapp3.1\Random123.txt"))
                {
                string a = sr.ReadLine();
                b.Add(int.Parse(a));
                while ((a = sr.ReadLine()) != null)
                    b.Add(int.Parse(a));
                }
           
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                b = Quick(b);
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Console.WriteLine(ts.Minutes + " " + ts.Seconds + " " + ts.Milliseconds);
              
            


        }
    }
}
