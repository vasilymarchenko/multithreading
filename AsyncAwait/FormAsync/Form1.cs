using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: rework it into async call
            label1.Text = DoLong();
        }

        private string DoLong()
        {
            Thread.Sleep(5000);
            return "The Long work is done!";
        }
    }
}
