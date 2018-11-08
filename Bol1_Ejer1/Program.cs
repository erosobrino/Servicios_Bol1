using System;

namespace Bol1_Ejer1
{
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

        delegate void MyDelegate();

        public static bool MenuGenerar(string[] nombreOpciones, Delegate[] delegados)
        {
            if (nombreOpciones.Length == delegados.Length || (nombreOpciones.Length - 1) == delegados.Length)
            {
                int eleccion = -1;
                for (int i = 0; i < nombreOpciones.Length; i++)
                {
                    Console.WriteLine("{0,2}.{1}", (i + 1), nombreOpciones[i]);
                }
                Console.WriteLine("Write your election");
                try
                {
                    eleccion = Convert.ToInt32(Console.ReadLine());
                    delegados[eleccion - 1].DynamicInvoke();
                }
                catch
                {
                    Console.WriteLine("This isn't a valid value");
                }
                if (eleccion == nombreOpciones.Length)
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("There aren't functions for every option");
            }
            Console.WriteLine();
            return false;
        }

        static void Main(string[] args)
        {
            bool salir=false;
            do
            {
                salir=MenuGenerar(new string[] { "Option1", "Option2", "Option3", "Exit" }, new MyDelegate[] { f1, f2, f3,fSalir });
            } while (!salir);
            Console.ReadKey();
        }
    }
}
