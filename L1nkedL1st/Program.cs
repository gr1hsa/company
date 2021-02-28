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
                 Console.WriteLine(ts.Minutes + " " + ts.Seconds + " " + ts.Milliseconds);



             MyLinkedList<int> f = new MyLinkedList<int>();
             f.AddLast(1);
             Console.WriteLine(f.GetElement(0));
             f.Add(new Item<int>(2));*/
            #endregion
            #region Проверка ICollection<T>
            /*MyLinkedList<int> add = new MyLinkedList<int>();
            add.Add(1);
            Item<int> addcheck = new Item<int>(12);
            add.Add(addcheck);
            Console.WriteLine("Проверка Add:");
            foreach (int i in add)
                Console.WriteLine(i);
            add.Clear();
            Console.WriteLine("Проверка Clear:");
            foreach (int i in add)
                Console.WriteLine(i);
            Console.WriteLine("Проверка Contains:");
            add.Add(123);
            for(int i = 0; i < 10; i++)
                add.Add(i);
            add.Add(addcheck);
            Console.WriteLine(add.Contains(123) + "  "  + add.Contains(11) + "  " + add.Contains(addcheck));
            Console.WriteLine("Проверка CopyTo");
            Item<int>[] copyto1 = new Item<int>[100];
            Item<int>[] copyto2 = new Item<int>[3];
            add.CopyTo(copyto1, 1);
            add.CopyTo(copyto2, 2);
            Console.WriteLine("Проверка Remove");
            foreach(int i in add)
                Console.Write(i + " ");
            Console.WriteLine();
            add.Remove(1);
            add.Remove(addcheck);
            foreach (int i in add)
                Console.Write(i + " ");
            Console.WriteLine();*/

            #endregion
            #region Проверка IEnumerable<T>
            //Console.WriteLine("Проверки не будет");
            #endregion
            #region Проверка IComparable
            /*MyLinkedList<int> list1 = new MyLinkedList<int>(123);
            MyLinkedList<int> list2 = new MyLinkedList<int>();
            MyLinkedList<string> list3 = new MyLinkedList<string>("AAAAAAAA");
            for(int i = 0; i < 10; i++)
            {
                list1.Add(i);
                list2.Add(i);
            }
            Console.WriteLine(list1.CompareTo(list2));
            Console.WriteLine(list1.CompareTo(list3));*/
            #endregion
            #region Проверка IClonable
           /*MyLinkedList<int> orig = new MyLinkedList<int>();
            for (int i = 0; i < 10; i++)
                orig.Add(i);
            MyLinkedList<int> copylink = orig;
            MyLinkedList<int> clone = (MyLinkedList<int>)orig.Clone();
            foreach (int i in orig)
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (int i in copylink)
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (Item<int> i in clone)
                Console.Write(i.value + " ");
            Console.WriteLine();
            orig.Remove(1);
            orig.Remove(2);
            foreach(int i in orig)
                Console.Write(i + " ");
            Console.WriteLine();
            foreach(int i in copylink)
                Console.Write(i + " ");
            Console.WriteLine();
            foreach(int i in clone)
                Console.Write(i + " ");
            Console.WriteLine();*/


            #endregion
            #region Проверка Sort
            MyLinkedList<int> sort = new MyLinkedList<int>();
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
                sort.Add(rnd.Next(123, 1000));
            foreach (int i in sort)
                Console.Write(i + " ");
            Console.WriteLine();
            sort.Sort(new ItemComparer<int>());
            foreach(int i in sort)
                Console.Write(i + " " );
   
            //Array.sort
            #endregion
    #region trash
                /*Item<int> a = new Item<int>(0);
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
                */
                #endregion
             Console.ReadKey();


        }
    }
}
