using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLINQdemo1 pLINQdemo1 = new PLINQdemo1();
            MessageBox.Show(pLINQdemo1.GetPrimeNumbers().Count().ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DictChecker dictChecker = new DictChecker();
            dictChecker.Check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaskDemo taskDemo = new TaskDemo();
            //MessageBox.Show(taskDemo.GetSite());
            //taskDemo.StateDemo();
            taskDemo.ContinueTasks();
        }
    }
}
