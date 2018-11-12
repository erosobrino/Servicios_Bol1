using System;

namespace Bol1_Ejer1
{
    //Validado
    class Program
    {
        bool salir = false;
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }
        static void fSalir()
        {
            Console.WriteLine("Good bye");
        }

        public delegate void MyDelegate();

        public static bool MenuGenerar(string[] optionsName, MyDelegate[] delegates)
        {
            if (optionsName.Length == delegates.Length)
            {
                int eleccion = -1;
                for (int i = 0; i < optionsName.Length; i++)
                {
                    Console.WriteLine("{0,2}.{1}", (i + 1), optionsName[i]);
                }
                Console.WriteLine("{0,2}.Exit", optionsName.Length + 1);
                Console.WriteLine("Write your election");
                try
                {
                    eleccion = Convert.ToInt32(Console.ReadLine());
                    if (eleccion == optionsName.Length + 1)
                    {
                        Console.WriteLine("Good Bye");
                        return true;
                    }
                    else
                    {
                        delegates[eleccion - 1].Invoke();
                    }
                }
                catch
                {
                    Console.WriteLine("This isn't a valid value");
                }
            }
            else
            {
                Console.WriteLine("There aren't functions for every option");
                return true;
            }
            Console.WriteLine();
            return false;
        }

        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
                salir = MenuGenerar(new string[] { "Option1", "Option2" , "op4" }, new MyDelegate[] { f1, f2,   () => Console.Write("boo") });
            } while (!salir);
            Console.ReadKey();
        }
    }
}
