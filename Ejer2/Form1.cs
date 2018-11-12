//#define pruebas
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2
{
    //Validado
    public partial class Processes : Form
    {
        public Processes()
        {
            InitializeComponent();
        }

        private void btProcess_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
#if pruebas
                if (p.MainWindowTitle.Contains("Pro"))
                {
                    tbText.AppendText(String.Format("{0,7}||{1,30}|| {2}\n", p.Id, p.ProcessName, p.MainWindowTitle));
                }
#endif
#if !pruebas
                tbText.AppendText(String.Format("{0,7}||{1,30}|| {2}\n", p.Id, p.ProcessName, p.MainWindowTitle));
#endif
            }
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Length > 0)
            {
                tbText.Clear();
                int id = pedirId();
                if (id != -1)
                {
                    try
                    {
                        Process p = Process.GetProcessById(id);
                        try
                        {
                            tbText.AppendText(p.Id + " " + p.StartTime + " " + p.StartInfo + Environment.NewLine);
                            try
                            {
                                tbText.AppendText("Modules info:" + Environment.NewLine);
                                foreach (ProcessModule module in p.Modules)
                                {
                                    try
                                    {
                                        tbText.Text += string.Format("Module: {0} {1}{2}", module, module.FileName,Environment.NewLine);
                                    }
                                    catch (Win32Exception)
                                    {
                                        tbText.AppendText("Access denied reading module");
                                    }
                                }
                            }
                            catch { tbText.AppendText("Access denied reading modules"); }
                            try
                            {
                                tbText.AppendText(Environment.NewLine + "Threads info:" + Environment.NewLine);
                                foreach (ProcessThread thread in p.Threads)
                                {
                                    try
                                    {
                                        tbText.Text += string.Format("Module ID: {0}\tInit {1}\tPriority {2}\tState {3}{4}", thread.Id, thread.StartTime.ToShortTimeString(), thread.PriorityLevel, thread.ThreadState,Environment.NewLine);
                                    }
                                    catch (Win32Exception)
                                    {
                                        tbText.AppendText("Access denied reading module");
                                    }
                                }
                                foreach (Thread thread in p.Threads)
                                {
                                    try
                                    {
                                        tbText.AppendText(thread.Name + "");
                                    }
                                    catch (Win32Exception)
                                    {
                                        tbText.AppendText("Access denied reading thread");
                                    }
                                }
                            }
                            catch { tbText.AppendText("Access denied reading threads"); }
                        }
                        catch (Win32Exception)
                        {
                            tbText.AppendText("Access denied");
                        }
                    }
                    catch
                    {
                        tbText.AppendText("Process not found");
                    }
                }
                else
                {
                    tbText.Text = "The process doesn't exists";
                }
            }
            else
            {
                tbText.Text = "You should write in the text box";
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Length > 0)
            {
                tbText.Clear();
                int id = pedirId();
                if (id != -1)
                {
                    try
                    {
                        Process p = Process.GetProcessById(id);
                        try
                        {
                            p.CloseMainWindow();
                            tbText.Text = "Trying to close the process";
                        }
                        catch (Win32Exception)
                        {
                            tbText.AppendText("Access denied");
                        }
                    }
                    catch
                    {
                        tbText.AppendText("Process not found");
                    }
                }
                else
                {
                    tbText.Text = "The process doesn't exists";
                }
            }
            else
            {
                tbText.Text = "You should write in the text box";
            }
        }

        private void btKill_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Length > 0)
            {
                tbText.Clear();
                int id = pedirId();
                if (id != -1)
                {
                    try
                    {
                        Process p = Process.GetProcessById(id);
                        try
                        {
                            p.Kill();
                            tbText.Text = "The process has been killed";
                        }
                        catch (Win32Exception)
                        {
                            tbText.AppendText("Access denied");
                        }
                    }
                    catch
                    {
                        tbText.AppendText("Process not found");
                    }
                }
                else
                {
                    tbText.Text = "The process doesn't exists";
                }
            }
            else
            {
                tbText.Text = "You should write in the text box";
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Length > 0)
            {
                tbText.Clear();
                //C:\Program Files\Notepad++\notepad++.exe
                Process p;
                try
                {
                    p = Process.Start(tbPath.Text);
                }
                catch (System.IO.FileNotFoundException)
                {
                    tbText.Text = "The path or the name doesn't exists";
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    tbText.Text = "The path or the name doesn't exists";
                }
            }
            else
            {
                tbText.Text = "You should write in the text box";
            }
        }

        private int pedirId()
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(tbPath.Text);
            }
            catch (FormatException)
            {
                tbText.Text = "This isn´t a valid number";
            }
            catch (OverflowException)
            {
                tbText.Text = "The number is too big";
            }
            return id;
        }
    }
}
