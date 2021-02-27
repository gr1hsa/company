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
            #region Мусор
           /* MyLinkedList<int> qq = new MyLinkedList<int>(10);
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
            Console.WriteLine(ts.Minutes + " " + ts.Seconds + " " + ts.Milliseconds);
            using (var sr = new StreamReader(@"C:\Users\гришша\source\repos\company\Random\bin\Debug\netcoreapp3.1\Random123.txt"))
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
            Console.WriteLine(ps.Minutes + " " + ps.Seconds + " " + ps.Milliseconds);
            MyLinkedList<int> b = new MyLinkedList<int> (0);
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
                Console.WriteLine(ts.Minutes + " " + ts.Seconds + " " + ts.Milliseconds);*/
              
            
            
            MyLinkedList<int> f = new MyLinkedList<int>();
            f.AddLast(1);
            Console.WriteLine(f.GetElement(0));
            f.Add(new Item<int>(2));
            #endregion

            Item<int> a = new Item<int>(0);
            Item<int> b = new Item<int>(1);
            Item<int> c = new Item<int>(2);
            Item<int> d = new Item<int>(3);
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            Console.WriteLine(list.Contains(c));
            list.Remove(3);
            list.Output();
            int[] copy = new int[1];
            list.CopyTo(copy, 9);
            foreach(Item<int> i in list)
                Console.WriteLine(i.value);
            Item<int> kk = new Item<int>(1);
            Item<int> ff = new Item<int>(2);
            Item<string> gg = new Item<string>("1");
            Item<decimal> dd = new Item<decimal>(1);
            Console.WriteLine(ff >= kk);
            MyLinkedList<int> tt = new MyLinkedList<int>();
            tt.Add(ff);
            tt.Add(kk);
            Item<int>[] mlist = new Item<int>[102];
            Random rnd = new Random();
            for (int i = 0; i < 102; i++)
                mlist[i] = new Item<int>(rnd.Next(0, 1000));
            //Array.Sort(tt, Item<int>, new ItemComparer<int>());
            foreach(Item<int> i in mlist)
                Console.WriteLine(i.value);

            

        }
    }
}
