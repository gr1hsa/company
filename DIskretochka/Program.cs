using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DIskretochka
{
    class Program
    {   
       
        public static List<int> Cont(List<Mytype> a, string s)
        {
            List<int> p = new List<int>();
            p.Add(0);
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i].str.ToString() == s)
                {
                    p[0] = 1;
                    p.Add(i);
                }
                
            }
            return p;
        }
        static void Main(string[] args)
        {
            int f, ss = 1;
            string s = Console.ReadLine();
            Dictionary<string, string> pp = new Dictionary<string, string>();
            List<Mytype> qq = new List<Mytype>();
            for (int i = 0; i < s.Length; i++)
            {
                f = Cont(qq, s[i].ToString())[0];
                if (f == 1)
                {
                    ss = Cont(qq, s[i].ToString())[1];
                    qq[ss].value += 1;
                }
                else
                    qq.Add(new Mytype(1, s[i].ToString()));

            }
            
            
            List<Mytype> copy = new List<Mytype>();
            for (int i = 0; i < qq.Count; i++)
            {
                copy.Add(new Mytype(qq[i].value, qq[i].str));
                Console.Write(qq[i].str + " ");
            }
                Console.WriteLine();
                for (int i = 0; i < qq.Count; i++)
            {
                pp.Add(qq[i].str, "");
            }

            int k , p, flag, t, check = 0, sum = 0;
            while(qq.Count != 1)
            {
                k = 1000000; p = -100; flag = 0; t = -100;
                for (int i = 0; i < qq.Count; i++)
                {
                    if(qq[i].value < k)
                    {
                        k = qq[i].value;
                        p = i;
                    }
                }
                while(flag == 0)
                {
                    
                    for(int i = 0; i < qq.Count; i++)
                    {
                        if (qq[i].value == k && i != p)
                        {
                            t = i;
                            flag = 1;
                        }

                    }
                    k++;
                    if (k == 1000000)
                        flag = 1;

                }
                
                for(int j = 0; j < qq[p].str.Length; j++ )
                    pp[qq[p].str[j].ToString()] += "0";
                for (int j = 0; j < qq[t].str.Length; j++)
                    pp[qq[t].str[j].ToString()] += "1";
                qq[p].value = qq[p].value + qq[t].value;
                qq[p].str = qq[p].str + qq[t].str;
                qq.RemoveAt(t);
                if (p > t)
                    p--;
                for (int i = 0; i < qq.Count; i++)
                {
                    if (i == p )
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(qq[i].str + " ");
                        Console.ResetColor();
                }
                Console.WriteLine();

            }
            foreach (KeyValuePair<string, string> keyValue in pp)
            {
                string val = " ";
                for (int i = keyValue.Value.Length - 1; i > -1; i--)
                    val += keyValue.Value[i];


                Console.WriteLine(keyValue.Key + " - " + val);
            }
            for(int i = 0; i < copy.Count; i++)
            {

                     sum += pp[copy[i].str].Length * copy[i].value;

            }
            Console.Write("Строка в закодированном виде:  " );
            for (int i = 0; i < s.Length; i++)
                Console.Write(pp[s[i].ToString()]);
            Console.WriteLine( );
            Console.WriteLine("Длинна закодированной строки:" + sum +  " ");

        }

       
    }
}
