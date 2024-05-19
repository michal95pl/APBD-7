using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task12();
            //Console.WriteLine(t);
            foreach (var V in t)
            {
                Console.WriteLine(V);    
            }
        }
    }
}
