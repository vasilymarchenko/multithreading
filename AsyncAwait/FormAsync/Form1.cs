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

namespace FormAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = DoLong().Result;
            //label1.Text = DoLong().Result;
            label1.Text = await DoLong();
        }

        
        //private string DoLong()
        //{
        //    Thread.Sleep(5000);
        //    return "The Long work is done!";
        //}

        //private Task<string> DoLong()
        //{
        //    return Task.Run(() =>
        //        {
        //            Thread.Sleep(5000);
        //            return "The Long work is done!";
        //        }
        //    );
        //}

        private async Task<string> DoLong()
        {
            return await Task.Run(() =>
                {
                    Thread.Sleep(5000);
                    return "The Long work is done!";
                }
            );
        }
    }
}
