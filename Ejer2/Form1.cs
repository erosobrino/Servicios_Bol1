//#define pruebas
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2
{
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
                if (p.MainWindowTitle.Contains("Telegram"))
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
                    Process p = Process.GetProcessById(id);
                    try
                    {
                        tbText.AppendText(p.Id + " " + p.StartTime + " " + p.Threads.Count + " " + p.Modules + " " + p.StartInfo);
                    }
                    catch (Win32Exception)
                    {
                        tbText.AppendText("Acceso Denegado");
                    }
                }
                else
                {
                    tbText.Text = "The process doesn't exists";
                }
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
                    Process p = Process.GetProcessById(id);
                    try
                    {
                        p.CloseMainWindow();
                        tbText.Text = "The process has been closed";
                    }
                    catch (Win32Exception)
                    {
                        tbText.AppendText("Acceso Denegado");
                    }
                }
                else
                {
                    tbText.Text = "The process doesn't exists";
                }
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
                    Process p = Process.GetProcessById(id);
                    try
                    {
                        p.Kill();
                        tbText.Text = "The process has been killed";
                    }
                    catch (Win32Exception)
                    {
                        tbText.AppendText("Acceso Denegado");
                    }
                }
                else
                {
                    tbText.Text = "The process doesn't exists";
                }
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
