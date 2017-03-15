using System;
using System.Threading;

namespace netCoreDemo.ThreadJoinDemo
{
    class Program
    {
        /*
            a.输出结果为：01234501234567896789 
            b.输出结果为：01234567890123456789 
            c.输出结果为：00112233445566778899 
            c.结果不确定

            正确答案：b
        */
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(DoWork));
            Thread t2 = new Thread(new ThreadStart(DoWork));
            t.Start();
            t2.Start();
            t.Join();
            t2.Join();
            Console.ReadKey();
        }

        private static void DoWork()
        {
            for(var i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
        }
    }
}