using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string returnString = client.GetData(textBox1.Text);
            label1.Text = returnString;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v = 0;
            int.TryParse(textBox2.Text, out v);
            ServiceReference2.Service2Client client = new ServiceReference2.Service2Client();
            string returnString = client.GetData(v);
            label2.Text = returnString;
        }
    }
}
