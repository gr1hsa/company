using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace NedoGeneric
{
    public class List<T> 
    {

        public Item<T> Head = new Item<T>();
        public List() { }
        public List(T Value)
        {
            Head.value = Value;
        }
        public void AddEnd(T s)
        {
            Item<T> temp = Head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = new Item<T>(s);
        }
        public int AmountElement()
        {
            int k = 1;
            Item<T> temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                k++;
            }
            return k;
        }
        public void Output()
        {
            Item<T> temp = Head;
            while (temp.Next != null)
            {

                Console.WriteLine(temp.value);
                temp = temp.Next;
            }
            Console.WriteLine(temp.value);

        }
        public T OutputEl(int n)
        {
            Item<T> temp = Head;
            int t = 0;
            int k = AmountElement();
            try
            {   
                if(n < 0)
                {
                    temp = null;
                    t = n - 1;
                }
                while (t < n)
                {
                    temp = temp.Next;
                    t++;
                }
                return(temp.value);

            }
            catch
            {
                
                Console.WriteLine("Вы пытаетесь запросить элемент, которого не существует.");
                return default(T);
            }
            

        }
        public void NewHead()
        {
            Item<T> item = new Item<T>();
            item.Next = Head;
            Head = item;
        }
        public void NewHead(T s)
        {
            Item<T> item = new Item<T>(s);
            item.Next = Head;
            Head = item;
        }
        public void DeleteItem(int n)
        {
            int t = 1;
            int k = AmountElement();
            Item<T> previous = Head;
            Item<T> temp = Head.Next;
            try
            {   if (n < 0)
                    temp = null;
                if (n == 0)
                    Head = Head.Next;
                else
                {
                    while (t < n)
                    {
                        t++;
                        previous = temp;
                        temp = temp.Next;
                    }
                    previous.Next = temp.Next;
                }
                
            }
            catch
            {
                Console.WriteLine("Вы пытаетесь удалить элемент, которого не существует.");
            }
        }
        public void UniqueList() 
        {
            
            Item<T> temp = Head;
            int k = AmountElement();
            int p = 1;
            Dictionary<int, T> val = new Dictionary<int, T>();
            val.Add(0, temp.value);
            temp = temp.Next;
            Item<T> temp2 = Head;
            for(int i = 0; i < k ; i++)
            {
                int f = 0;
                for(int j = 0; j < p; j++)
                {
                    if ((temp != null) && (temp.value.Equals(val[j])) && (f == 0))
                    {
                        temp2.Next = temp2.Next.Next;
                        temp = temp2.Next;
                        f = 1;
                       
                    }
                    
                }
                if ((f == 0) && (temp != null))
                {
                    val.Add(p, temp.value);
                    p++;
                    temp = temp.Next;
                    temp2 = temp2.Next;
                }
            }
        }
        public List<string> ReadingFileString(string s)
        {   
            
            List<string> qq = new List<string>();
            using (var sr = new StreamReader(s))
                {
                    string a = sr.ReadLine();
                    qq.NewHead(a);
                    qq.DeleteItem(1);
                    while ((a = sr.ReadLine()) != null)
                        qq.AddEnd(a);

                }
                return (qq);
        }
        public List<int> ReadingFileInt(string s)
        {

            List<int> qq = new List<int>();
            using (var sr = new StreamReader(s))
            {
                string a = sr.ReadLine();
                qq.NewHead(int.Parse(a));
                qq.DeleteItem(1);
                while ((a = sr.ReadLine()) != null)
                    qq.AddEnd(int.Parse(a));

            }
            return (qq);
        }
        public void WritingFileString(string s)
        {
            Item<T> temp = Head;
            using (var sw = new StreamWriter(s))
            {
               
                while (temp != null)
                {
                    sw.WriteLine(temp.value);
                    temp = temp.Next;
                }
            }
        }
        public void WritingFileInt(string s)
        {
            Item<T> temp = Head;
            using (var sw = new StreamWriter(s))
            {

                while (temp != null)
                {
                    sw.WriteLine(temp.value.ToString());
                    temp = temp.Next;
                }
            }
        }
        public T KFromTheEnd(int k) 
        {
            
            try
            {
                if(k < 0 || k > AmountElement() - 1)
                    throw new ArgumentException();
                Item<T> first = Head;
                Item<T> second = Head;
                for (int i = 0; i < k; i++)
                    first = first.Next;
                while(first.Next != null)
                {
                    first = first.Next;
                    second = second.Next;
                }

                return second.value;
            }
            catch
            {
                Console.WriteLine("Плохо");
                return default(T);
            }
        }
        /*public bool PalindromeCheck()
        {
            int flag = 0;
            int c = AmountElement() % 2;
            Item<T> fast = Head;
            Item<T> slow = Head;
            Stack<T> qu = new Stack<T>();
            if (c == 1) 
            {   
                while (fast.Next != null)
                {
                    qu.Push(slow.value);
                    fast = fast.Next.Next;
                    slow = slow.Next;
                }
                slow = slow.Next;
            }
            else
            {
                while (fast.Next.Next != null)
                {
                    qu.Push(slow.value);
                    fast = fast.Next.Next;
                    slow = slow.Next;
                }
                qu.Push(slow.value);
                slow = slow.Next;
            }
            while((slow != null) && (flag == 0))
            {
                if (slow.value.Equals(qu.Pop()) == false)
                    flag = 1;
                slow = slow.Next;

            }
            if (flag == 1)
                return false;
            else
                return true;
        }*/
        public bool PalindromeCheck()
        {
            int flag = 0;
            Item<T> fast = Head;
            Item<T> slow = Head;
            Stack<T> qu = new Stack<T>();
           while (fast.Next != null && fast.Next.Next != null)
           {
                    qu.Push(slow.value);
                    fast = fast.Next.Next;
                    slow = slow.Next;
           }
           if(AmountElement() % 2 == 0)
                qu.Push(slow.value);
            slow = slow.Next;

           while ((slow != null) && (flag == 0))
            {
                if (slow.value.Equals(qu.Pop()) == false)
                    flag = 1;
                slow = slow.Next;
            }
            if (flag == 1)
                return false;
            else
                return true;
        }

    }
}
