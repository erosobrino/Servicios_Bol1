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
    //Validado
    public partial class Game : Form
    {
        bool finish = false;
        bool displayStop = false;
        bool start = true;
        bool created = false;
        static readonly private object l = new object();
        delegate void DelegaTB(string texto, TextBox t);
        delegate void DelegaLB(string texto, Label lb);
        delegate void DelegaColor(RichTextBox tb);
        Random rand = new Random();
        Thread display;
        Thread threadPlayer1;
        Thread threadPlayer2;
        int num;
        public Game()
        {
            InitializeComponent();
            display = new Thread(flash);
            threadPlayer1 = new Thread(() => points(1));
            threadPlayer2 = new Thread(points);
            display.IsBackground = true;
            threadPlayer1.IsBackground = true;
            threadPlayer2.IsBackground = true;
            display.Start();
            threadPlayer1.Start();
            threadPlayer2.Start(2);
        }

        public void flash()
        {
            DelegaColor dColor = new DelegaColor(changeColor);
            while (!finish)
            {
                lock (l)
                {
                    if (created && !finish)
                    {
                        if (displayStop)
                        {
                            Monitor.Wait(l);
                        }
                        if (!displayStop)
                        {
                            try
                            {
                                this.Invoke(dColor, tbColor);
                            }
                            catch (ObjectDisposedException) { return; }
                        }
                    }
                }
                Thread.Sleep(200);
            }
        }

        public void points(object id)
        {
            int player = Convert.ToInt32(id);
            DelegaTB dTB = new DelegaTB(changeText);
            DelegaLB dLB = new DelegaLB(changeTextLabel);
            Label[] labels = new Label[] { lbRand1, lbRand2 };
            int number = 0;
            while (!finish)
            {
                if (created)
                {
                    lock (l)
                    {
                        if (!finish)
                        {
                            number = rand.Next(1, 11);
                            try
                            {
                                this.Invoke(dLB, number + "", labels[player - 1]);
                            }
                            catch (ObjectDisposedException) { return; }
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
                                        start = false;
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
                                    Monitor.Pulse(l);
                                }
                                try
                                {
                                    this.Invoke(dTB, num + "", textBox1);
                                }
                                catch (ObjectDisposedException) { return; }
                                //catch (Exception) { }
                            }
                            if (num >= 20 || num <= -20)
                            {
                                finish = true;
                                try
                                {
                                    this.Invoke(dLB, "The winner is player " + id, label1);
                                }
                                catch (ObjectDisposedException) { return; }
                                //catch (Exception) { }
                            }
                        }
                    }
                    Thread.Sleep(rand.Next(100, number * 100));
                }
            }
        }

        private void changeColor(RichTextBox tb)
        {
            tb.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
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

        private void Juego_Load(object sender, EventArgs e)
        {
            created = true;
        }
    }
}
