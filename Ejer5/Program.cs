using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejer5
{
    public delegate void MyDelegate();
    class MyTimer
    {
        //Validado
        static readonly private object l = new object();
        public int interval = 1000;
        MyDelegate function;
        bool finish = false;
        bool boolStop = true;
        static int counter = 0;
        Thread thread;

        public MyTimer(MyDelegate del)
        {
            this.function = del;
            thread = new Thread(startFunction);
            thread.IsBackground = true;
            thread.Start();
        }

        public void startFunction()
        {

            while (!finish)
            {
                lock (l)
                {
                    if (boolStop)
                    {
                        Monitor.Wait(l);
                    }
                    if (!finish)
                    {
                        function();
                    }


                }
                Thread.Sleep(interval);
            }
        }

        public void stop()
        {
            lock (l)
                boolStop = true;
        }

        public void Start()
        {
            lock (l)
            {
                boolStop = false;
                Monitor.Pulse(l);
            }
        }

        static void Increment()
        {
            counter++;
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            MyTimer t = new MyTimer(Increment);
            t.interval = 1000;
            string op = "";
            do
            {
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                t.Start();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
                t.stop();
                Console.WriteLine("Press 1 to restart or Enter to end.");
                op = Console.ReadLine();
            }
            while (op == "1");
            //t.finish = true;
            //lock (l)
            //    Monitor.Pulse(l);
        }
    }
}