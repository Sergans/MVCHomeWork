using System;
using System.Threading;
using System.Collections.Generic;

namespace MVCLesson_1_2
{
    
    public class Operation<T>
    {
        private static object lockObject = new object();
        public List<T> ls = new List<T>();
        public void Add(T item)
        {
            
            //lock (ls)
            {
                ls.Add(item);
                Thread.Sleep(1000);
            }
            
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
            //op.Add("11ffghff");
            //op.Add("22fffff");
            for(int i = 0; i < 20; i++)
            {
                Thread tred = new Thread(new ThreadStart(() => op.Add($"ffffff{i}")));
                tred.Start();
            }
           
           // Thread.Sleep(2000);
            for (int i = 0; i < op.ls.Count; i++)
            {
                Console.WriteLine(op.ls[i]);
            }
            
        }
    }
}
