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
        bool created = false;
        static readonly private object l = new object();
        delegate void Delega(string texto, TextBox t);
        delegate void Delega2(string texto, Label lb);
        delegate void DelegaColor(RichTextBox tb);
        Random rand = new Random();
        Thread display;
        Thread threadPlayer1;
        Thread threadPlayer2;
        int num;
        public Juego()
        {
            InitializeComponent();
            display = new Thread(parpadeo);
            display.Start();
            threadPlayer1 = new Thread(points);
            threadPlayer1.Start(1);
            threadPlayer2 = new Thread(points);
            threadPlayer2.Start(2);
        }

        public void parpadeo()
        {
            DelegaColor dColor = new DelegaColor(changeColor);
            while (!finish)
            {
                lock (l)
                {
                    if (!displayStop && created && !finish)
                    {
                        try
                        {
                            this.Invoke(dColor, tbColor);
                        }
                        catch { }
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
                        number = rand.Next(1, 11);
                        try
                        {
                            this.Invoke(dLB, number + "", labels[player - 1]);
                        }
                        catch { }
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
                            try
                            {
                                this.Invoke(dTB, num + "", textBox1);
                            }
                            catch { }
                        }
                        start = false;
                        if (num >= 20 || num <= -20)
                        {
                            finish = true;
                        }
                    }
                }
                Thread.Sleep(rand.Next(100, number * 100));
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
