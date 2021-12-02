using System;
using System.Threading;
using System.Collections.Generic;

namespace MVCLesson_1_2
{
    public class Operation<T>
    {
        List<T> ls = new List<T>();
    }
    class Program
    {
        static void Foo()
        {
            
        }
        static void Main(string[] args)
        {
            Thread f = new Thread(Foo);
            f.Start();
           
        }
    }
}
