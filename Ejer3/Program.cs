using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejer3
{
    class Program
    {
        static bool parar = false;
        static int num = 0;
        static int corriendo = 0;
        static readonly private object l = new object();

        public delegate int Operation(int num);

        static void Main(string[] args)
        {
            Operation op1 = new Operation((num) => num++);
            Operation op2 = new Operation((num) => num--);

            Thread thread1 = new Thread(numPos);
            Thread thread2 = new Thread(numPos);
            thread1.Start(op1);
            thread2.Start(op2);



            Console.ReadKey();
        }

        static void numPos(object a)
        {
            Console.WriteLine(num);
            num = ((Operation)a)(num);
            
        }
    }
}
