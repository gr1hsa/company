using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace L1nkedL1st
{
    public class MyLinkedList<T> : ICloneable, ICollection<T>
    {
        
        public Item<T> Head = null;
        public Item<T> Tail = null;
        public int Count { get; set; } //Колво элементов

        public bool IsReadOnly => false;

        public MyLinkedList() 
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public MyLinkedList(T value) 
        {
            Item<T> item = new Item<T>(value);
            Head = item;
            Tail = item;
            Count = 1;

        }
        public void AddLast(T value)    //Добавить в конец элемент
        {
            if (Head == null)
            {
                Head = new Item<T>(value);
                Tail = new Item<T>(value);
                Count++;
            }
            else
            {

                Item<T> item = new Item<T>(value);
                item.Previous = Tail;
                Tail.Next = item;
                Tail = item;
                Count++;
            }

        }
        public void AddFirst(T value) //Добавить в начало элемент
        {
            Item<T> item = new Item<T>(value);
            item.Next = Head;
            Head.Previous = item;
            Head = item;
            Count++;
        }
        public void AddAfter(int a, T value) // Добавляет элемент после н-го элменета
        {
            Item<T> item = Head;    
            Item<T> item1 = new Item<T>(value);
            if (a >= Count - 1)
                AddLast(value);
            else if (a <= -1)
                AddFirst(value);
            else
            {
                while ((a > 0) && (item.Next != null))
                {
                    item = item.Next;

                    a--;
                }
                item1.Next = item.Next;
                item.Next = item1;
                item1.Previous = item;
                item = item1.Next;
                item.Previous = item1;
                Count++;
            }
            
        }
        public void AddBefore(int a, T value) // Добавляет элемент перед н-ым элменетом
        {
            Item<T> item = Head;   
            Item<T> item1 = new Item<T>(value);
            if (a <= 0)
                AddFirst(value);
            else if (a >= Count)
                AddLast(value);
            else
            {
                while ((a > 1) && (item.Next != null))
                {
                    item = item.Next;
                    a--;
                }
                item1.Previous = item;
                item1.Next = item.Next;
                item.Next = item1;
                item = item1.Next;
                item.Previous = item1;
                Count++;
            }
            
        }
        public void Clear() // В списке остаётся 1 пустой элемент
        {
            Item<T> item = new Item<T>();
            Head = item;
            Tail = item;
            Count = 1;
        }
        public bool Contains(T value) // Проверяет имеется ли элемент с заданным значением в данном списке
        {
            bool a = false;
            int flag = 0;
            Item<T> item = Head;
            while(item != null)
            {
                if (item.value.Equals(value) && flag == 0)
                {
                    a = true;
                    flag = 1;
                }
                item = item.Next;
            }
            return a;
        }
        public void CopyTO() { }
        public int Find(T value) // Возвращает номер первого элемента с заданным значением
        {
            Item<T> item = Head;
            int a = 0;
            int flag = 0;
            while(item != null && flag == 0)
            {
                if (item.value.Equals(value))
                    flag = 1;
                a++;
                item = item.Next;
            }
            if (a < Count)
                return a;
            else
                return -1;
            
        }
        public int FindLast(T value) // Возвращает номер последнего элемента с заданным значением
        {
            Item<T> item = Tail;
            int a = Count - 1;
            int flag = 0;
            while (item != null && flag == 0)
            {
                if (item.value.Equals(value))
                    flag = 1;
                a--;
                item = item.Previous;
            }
            if (a > -1)
                return a;
            else
                return -1;
        }
        public void GetEnumerator() { }
        public void GetObjectData() { }
        public void OnDeserialization() { }
        public void Remove(T value) //удаляет первый элемент с заданным значением
        {
            Item<T> item = Head;
            Item<T> item1 = Head.Next;
            int t = 0;
            if(item.value.Equals(value))
            {
                RemoveFirst();
                t = 1;
            }
            item = item.Next;
            while((item.Next != null) && (t != 1))
            {
                if(item.value.Equals(value))
                {
                    item = item.Previous;
                    item.Next = item.Next.Next;
                    item1 = item1.Next;
                    item1.Previous = item;
                    t = 1;
                    Count--;
                }
                item = item.Next;
                item1 = item1.Next;
            }
            if((t != 1) && (item.value.Equals(value)))
            {
                RemoveLast();
            }
        }
        public void RemoveFirst() //Удаляет первый элемент листа
        {
            Item<T> item = Head.Next;
            item.Previous = null;
            Head = item;
            Count--;

        }
        public void RemoveLast() //Удаляет последний элемент листа
        {
            Item<T> item = Tail.Previous;
            item.Next = null;
            Tail = item;
            Count--;

        }
        public T GetElement(int a) //Получить н-ый элемент листа
        {
            Item<T> item = Head;
            try
            {
                if (a < 0)
                    item = Tail.Next;
                while ((a >= 1))
                {
                    a--;
                    item = item.Next;
                }
                return (item.value);
            }
            catch
            {
                Console.WriteLine("Данного элеменета нет");
                return default;

            }

        }
        public void Delete(int a)
        {
            try
            {
                Item<T> item = Head;
                if (a < 0)
                    throw new ArgumentException();
                else if (a == 0)
                    RemoveFirst();
                else if (a == Count - 1)
                    RemoveLast();
                else
                {
                    while (a > 1 && item.Next != null)
                    {
                        a--;
                        item = item.Next;
                    }
                    item.Next = item.Next.Next;
                    item = item.Next;
                    item.Previous = item.Previous.Previous;
                    Count--;
                }
            }
            catch
            {
                Console.WriteLine("Нет");
            }
        }
            
        public void Output() //Вывести весь списокб
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetElement(i));
            }
        }
        public int AmountOfElemnts()
        {
            Item<T> item = Head;
            int k = 1;
            while(item.Next != null)
            {
                k++;
                item = item.Next;
            }
            return k;
        }
        public void Swap(int a)
        {
            T x;
            Item<T> item = Head;
            while(a > 0 && item.Next != null)
            {
                a--;
                item = item.Next;
            }
            x = item.value;
            item.value = item.Next.value;
            item.Next.value = x;
        }
        public void BubbleSort()
        {
            T x;
            Item<T> item = Head;
            for(int i = 0; i < Count - 1; i++)
            {
                for(int j = 0; j < Count - 1 - i; j++)
                {
                   var compareResult = ((IComparable)item.value).CompareTo((IComparable)item.Next.value);
                    if(compareResult == 1)
                    {
                        x = item.value;
                        item.value = item.Next.value;
                        item.Next.value = x;
                     }
                    item = item.Next;
                }
                item = Head;
            }
        }
        public void QuickSort(int l, int r)
        {
            int m1 = l, m2 = 0; 
            T peremen;
            Item<T> item = Head;
            
            if(r - l > 1)
            {
                for (int i = 0; i < l; i++)
                    item = item.Next;
                Random rnd = new Random();
                int a = rnd.Next(l, r);
                T b = GetElement(a);
                for (int i = l; i < r; i++)
                {
                    var compareResult = ((IComparable)b).CompareTo((IComparable)item.value);
                    if (compareResult == 1)
                    {
                        if (m1 + m2 == i )
                        {
                            peremen = item.value;
                            item.value = GetElement(m1);
                            ChangeValue(m1, peremen);
                            m1++;
                        }
                        if (m1 + m2 < i )
                        {
                            peremen = item.value;
                            item.value = GetElement(m1);
                            ChangeValue(m1, peremen);
                            m1++;
                            peremen = item.value;
                            item.value = GetElement(i - m2);
                            ChangeValue(i - m2, peremen);
                        }

                    }
                    else if (compareResult == 0)
                    {
                        peremen = item.value;
                        item.value = GetElement(i - m2);
                        ChangeValue(i - m2, peremen);
                    }

                    else
                    {
                        m2++;
                    }
                    item = item.Next;
                   
                }
                QuickSort(l, m1);
                QuickSort(r - m2, r);
            }
            
        }
        public void ChangeValue(int a, T b)
        {
            Item<T> item = Head;
            while(a > 0)
            {
                item = item.Next;
                a--;
            }
            item.value = b;
        }

        public object Clone() // Создаёт копию листа(не ссылка)
        {
            Item<T> item = Head;
            MyLinkedList<T> list = new MyLinkedList<T>(item.value);
            for(int i = 0; i < Count - 1; i++)
            {   
                item = item.Next;
                list.AddLast(item.value);                
            }
            return list;
        }

        public void Add(Item<T> item) //Добавление самого эллемента в лист(ссылка)
        {
            if (Head == null)
            {
                Head = item;
                Tail = item;
                Count++;
            }
            else
            {
                item.Previous = Tail;
                Tail.Next = item;
                Tail = item;
                Count++;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
