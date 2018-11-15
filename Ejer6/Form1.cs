using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer6
{
    public partial class Juego : Form
    {
        bool finish = false;
        bool displayStop = false;
        bool start = true;
        static readonly private object l = new object();
        delegate void Delega(string texto, TextBox t);
        delegate void Delega2(string texto, Label lb);
        Random rand = new Random();
        int num;
        int playerGaming = 0;
        public Juego()
        {
            InitializeComponent();
            Thread display = new Thread(parpadeo);
            display.Start();
            Thread player1 = new Thread(points);
            player1.Start(1);
            Thread player2 = new Thread(points);
            player2.Start(2);
        }

        public void parpadeo()
        {
            Label[] labels = new Label[] { player1, player2 };
            while (!finish)
            {
                lock (l)
                {
                    if (!displayStop&&playerGaming!=0)
                    {
                        if (labels[playerGaming - 1].ForeColor != Color.Green)
                        {
                            labels[playerGaming - 1].ForeColor = Color.Green;
                        }
                        else
                        {
                            labels[playerGaming - 1].ForeColor = Color.Black;
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        public void points(object id)
        {
            int player = Convert.ToInt32(id);
            Delega dTB = new Delega(changeText);
            Delega2 dLB = new Delega2(changeTextLabel);
            Label[] labels = new Label[] { lbAlea1, lbAlea2 };
            int number = 0;
            while (!finish)
            {
                lock (l)
                {
                    if (!finish)
                    {
                        playerGaming = player;
                        number = rand.Next(1, 11);
                        this.Invoke(dLB, number + "", labels[player - 1]);
                        if (number == 5 || number == 7)
                        {
                            if (player == 1)
                            {
                                if (displayStop)
                                {
                                    num += 5;
                                }
                                else
                                {
                                    num++;
                                }
                                displayStop = true;
                            }
                            else
                            {
                                if (start)
                                {
                                    num--;
                                }
                                else
                                {
                                    if (!displayStop)
                                    {
                                        num -= 5;
                                    }
                                    else
                                    {
                                        num--;
                                    }

                                }
                                displayStop = false;
                            }
                            this.Invoke(dTB, num+"", textBox1);
                        }
                        start = false;
                        if (num == 20 || num == -20)
                        {
                            finish = true;
                        }
                    }
                }
                Thread.Sleep(rand.Next(100, number * 100));
            }
        }

        private void changeText(string texto, TextBox t)
        {
            t.AppendText(texto + Environment.NewLine);
        }

        private void changeTextLabel(string text, Label lb)
        {
            lb.Text = text;
        }

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            finish = true;
        }
    }
}
