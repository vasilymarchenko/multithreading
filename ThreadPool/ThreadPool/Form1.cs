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

namespace ThreadPoolDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bStartNewWorker_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            ThreadPool.QueueUserWorkItem(Do, rnd.Next(100, 1000));
        }

        private static void Do(object data)
        {
            int load = 100;
            int.TryParse(data.ToString(), out load);
            Worker.DoWork(load);
        }

        private void bShowMsg_Click(object sender, EventArgs e)
        {
            ProcessThreadCollection currentThreads = Process.GetCurrentProcess().Threads;


            foreach (ProcessThread thread in currentThreads)
            {
                Console.WriteLine($"Thread:{thread.Id}");
            }

            MessageBox.Show($"Threads using: {currentThreads.Count}");
        }
    }
}
