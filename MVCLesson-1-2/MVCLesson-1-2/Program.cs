using System;
using System.Threading;
using System.Collections.Generic;

namespace MVCLesson_1_2
{
    public class Operation<T>
    {
       public List<T> ls = new List<T>();
        public void Add(T item)
        {
            Thread.Sleep(1000);
            lock (ls) ;
            ls.Add(item);
        }
        public void Delete(T item)
        {
            ls.Remove(item);
        }
    }
    class Program
    {
        static void Foo()
        {
            
        }
        static void Main(string[] args)
        {
            Operation<string> op = new Operation<string>();
            Thread tred = new Thread(() => op.Add("ffffff"));
            Thread tred1 = new Thread(() => op.Add("aaaaaa"));
            tred.Start();
            tred1.Start();
            Thread.Sleep(1000);
           foreach(var s in op.ls)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
