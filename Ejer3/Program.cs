using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static Ejer3.Program;

namespace Ejer3
{
    //Validado
    class Data
    {
        public Operation op;
        public int idThread;

        public Data(Operation op, int idThread)
        {
            this.op = op;
            this.idThread = idThread;
        }
    }

    class Program
    {
        static bool stop = false;
        static int number = 0;
        public static int winner;
        static readonly private object l = new object();
        public delegate int Operation(int num);
        static long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        static void Main(string[] args)
        {
            Operation op1 = new Operation((num) => num + 1);
            Operation op2 = new Operation((num) => num - 1);

            Data p1 = new Data(op1, 1);
            Data p2 = new Data(op2, 2);

            Thread thread1 = new Thread(modifyValue);
            Thread thread2 = new Thread(modifyValue);
            thread1.Start(p1);
            thread2.Start(p2);
            thread1.Join();
            thread2.Join();

            Console.Write("The winner was the thread ");
            Console.WriteLine(winner);
            long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine(endTime - startTime);
            Console.ReadKey();
        }

        static void modifyValue(object a)
        {
            Data data = (Data)a;
            Operation op = data.op;
            while (!stop)
            {
                lock (l)
                {
                   
                    if (!stop)
                    {
                        number = ((Operation)op)(number);
                        Console.WriteLine("{0,5} Thread:{1}", number, data.idThread);
                        if (number == 1000 || number == -1000)
                        {
                            winner = data.idThread;
                            stop = true;
                        }
                    }
                }
            }
        }
    }
}
