using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejer4
{
    //Validado
    class Horse
    {
        public static int quantity = 0;
        public int idHorse;
        public string name;
        public int position;

        public Horse(string name)
        {
            this.idHorse = quantity;
            quantity++;
            this.name = name;
            this.position = 0;
        }
    }
    class Program
    {
        public static int horseQuantity = 0;
        public static int finishLine = 100;
        public int winnerElection;
        public int winnerHorse;
        public bool finish = false;
        static readonly private object l = new object();
        Random rand = new Random();
        static void Main(string[] args)
        {
            List<string> horseNames = new List<string> { "AAAA", "BBB", "CCC", "DDD", "EEE" };

            Console.CursorVisible = false;
            Program p = new Program();

            p.printStart(horseNames);
            p.startRace(horseNames);

            lock (l)
            {
                Monitor.Wait(l);
                Console.SetCursorPosition(0, horseQuantity + 1);
                Console.WriteLine("Your election was the horse {0}", p.winnerElection + 1);
                Console.WriteLine("The winner was the horse {0}.{1}", p.winnerHorse + 1, horseNames[p.winnerHorse]);
                if (p.winnerHorse == p.winnerElection)
                {
                    Console.WriteLine("Congratulations, you guessed the winnner");
                }
                else
                {
                    Console.WriteLine("You didn't guessed the winner");
                }
            }
            Console.ReadKey();
        }

        public void askWinner(List<string> horseNames)
        {
            int election = -1;
            do
            {
                clearLines(new int[] { horseNames.Count, horseNames.Count + 1 });
                Console.WriteLine("Who will be the winner (1-" + horseNames.Count + ")");
                try
                {
                    election = Convert.ToInt32(Console.ReadLine());
                    if (election < 1 || election > horseNames.Count)
                    {
                        election = -1;
                        throw new OverflowException();
                    }
                    winnerElection = election - 1;
                }
                catch (FormatException)
                {
                    clearLines(new int[] { horseNames.Count + 2 });
                    Console.WriteLine("This isn't a valid number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number isn't in the correct range");
                }
                clearLines(new int[] { horseNames.Count, horseNames.Count + 1 });
            } while (election == -1);
        }

        public void startRace(List<string> horseNames)
        {
            horseQuantity = horseNames.Count;
            for (int i = 0; i < horseNames.Count; i++)
            {
                Horse horse = new Horse(horseNames[i]);
                Thread threadHorse = new Thread(moveHorse);
                threadHorse.Start(horse);
            }
        }

        public void clearLines(int[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(0, lines[i]);
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, lines[0]);
        }

        public void printStart(List<string> horseNames)
        {
            for (int i = 0; i < horseNames.Count; i++)
            {
                Console.WriteLine("{0,2}.{1,5}", i + 1, horseNames[i]);
                Console.SetCursorPosition(finishLine + 7, i);
                Console.WriteLine("*");
            }
            askWinner(horseNames);
            Console.WriteLine("Press any key to start");
            clearLines(new int[] { horseNames.Count + 2 });
            Console.ReadKey(true);
            clearLines(new int[] { horseNames.Count });
        }

        public void moveHorse(object a)
        {
            Horse horse = (Horse)a;
            while (!finish)
            {
                Thread.Sleep(50);// rand.Next(100, 300));
                lock (l)
                {
                    if (!finish)
                    {
                        horse.position += 1;// rand.Next(1, 3);
                        int y = horse.idHorse;
                        int x = horse.position;
                        Console.SetCursorPosition(x, y);
                        /*for (int i = 0; i < x; i++)
                        {
                            Console.Write(" ");
                        }*/
                        Console.WriteLine("{0,2}.{1,5}", horse.idHorse + 1, horse.name);
                        if (x >= finishLine)
                        {
                            finish = true;
                            winnerHorse = horse.idHorse;
                            Monitor.Pulse(l);
                        }
                    }
                }
            }
        }
    }
}
