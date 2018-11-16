using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejer5
{
    public delegate void delegado();
    class MyTimer
    {
        static readonly private object l = new object();
        //static long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        public int interval = 100;
        delegado function;
        bool finish = false;
        static int counter = 0;

        public MyTimer(delegado delegado)
        {
            this.function = delegado;
        }

        public void stop()
        {
            finish = true;
        }

        public void start()
        {
            while (!finish)
            {
                lock (l)
                {
                    if (!finish)
                    {
                        function();
                        //long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                        //Console.WriteLine(endTime - startTime);
                    }
                }
                Thread.Sleep(interval);
            }
        }
        static void increment()
        {
            counter++;
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            MyTimer t = new MyTimer(increment);
            t.interval = 1000;
            string op = "";
            do
            {
                t.finish = false;
                counter = 0;
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                Thread thread1 = new Thread(t.start);
                thread1.Start();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
                t.stop();
                Console.WriteLine("Press 1 to restart or Enter to end.");
                op = Console.ReadLine();
            }
            while (op == "1");
        }

    }
}