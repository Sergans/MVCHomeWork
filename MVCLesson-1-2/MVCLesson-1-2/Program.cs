using System;
using System.Threading;
using System.Collections.Generic;

namespace MVCLesson_1_2
{
    
    public class Operation<T>
    {
        static object lockObject = new object();
        public List<T> ls = new List<T>();
        public void Add(T item)
        {
           
            lock (lockObject)
            {
                ls.Add(item);
               
            }
            Thread.Sleep(1000);
        }
        public void Delete(T item)
        {
            lock (lockObject)
            {
                ls.Remove(item);
            }
            Thread.Sleep(1000);
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
            
            for(int i = 0; i < 20; i++)
            {
                Thread tred = new Thread(new ThreadStart(() => op.Add($"ffffff{i}")));
                Thread.Sleep(10);
                tred.Start();
            }

            Thread thread = new Thread(() => op.Delete(op.ls[10]));
            thread.Start();
            Thread thread1 = new Thread(() => op.Delete(op.ls[10]));
            thread.Start();
            for (int i = 0; i < op.ls.Count; i++)
            {
                Console.WriteLine(op.ls[i]);
            }
            
        }
    }
}
