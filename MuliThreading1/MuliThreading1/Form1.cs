using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuliThreading1.BusinessLogic;

namespace MuliThreading1
{
    public partial class Form1 : Form
    {
        private SimpleCounter TheCounter;
        

        public Form1()
        {
            InitializeComponent();
            TheCounter = new SimpleCounter();
        }

        private void bShowMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just a message");
        }

        private void bStartSimpleWorker_Click(object sender, EventArgs e)
        {
            TheCounter.Count();
            MessageBox.Show($"The result of Counter = {TheCounter.Counter}");
        }

        private void bStartParallel_Click(object sender, EventArgs e)
        {
            //Thread backgroundThread = new Thread(...);

            //var starterDelegate = new ThreadStart(TheCounter.Count);
            Thread backgroundThread = new Thread(TheCounter.Count);
            backgroundThread.Name = "background";
            //backgroundThread.IsBackground = true;
            backgroundThread.Start();

            //MessageBox.Show($"The result of Counter = {TheCounter.Counter}");
        }

        private void bStartParallelParam_Click(object sender, EventArgs e)
        {
            int startPoint = GetStartPoint();

            //var paramDelegate = new ParameterizedThreadStart(TheCounter.CountFromStartPoint);
            Thread backgroundThread = new Thread(TheCounter.CountFromStartPoint);
            backgroundThread.Start(startPoint);
        }

        private int GetStartPoint()
        {
            int num = 0;

            string input = txtStartPoint.Text;
            int.TryParse(input, out num);

            return num;
        }

        private void bWaitingBackground_Click(object sender, EventArgs e)
        {
            Thread backgroundThread = new Thread(TheCounter.Count);
            backgroundThread.Name = "background";
            backgroundThread.Start();

            DoSomeHardWork(10);
            //SimpleCounter.waitHandle.WaitOne();
            backgroundThread.Join();

            MessageBox.Show($"The result of Counter = {TheCounter.Counter}");
        }

        private void DoSomeHardWork(int interval)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"Working hard-{i};");
                Thread.Sleep(interval);
            }
        }

        private void bParallel_Click(object sender, EventArgs e)
        {

            Thread t1 = new Thread(TheCounter.Count);
            t1.Name = "t1";

            Thread t2 = new Thread(TheCounter.Count);
            t2.Name = "t2";

            t1.Start();
            t2.Start();
        }

        delegate int LongOp();
        LongOp op;

        private void bAsyncDelegate_Click(object sender, EventArgs e)
        {
            Label.CheckForIllegalCrossThreadCalls = false;
            op = new LongOp(TheCounter.GetCount);
            //
            IAsyncResult result = op.BeginInvoke(OpCompleted, null);
            
            //while (!result.IsCompleted)
            //{
            //    Console.WriteLine("I am still waiting...");
            //    Thread.Sleep(1000);
            //}

            //lblResult.Text = op.EndInvoke(result).ToString();

        }

        private void OpCompleted(IAsyncResult result)
        {
            //AsyncResult ar = (AsyncResult) result;
            //LongOp op = (LongOp) ar.AsyncDelegate;

            lblResult.Text = op.EndInvoke(result).ToString();
        }
    }
}
