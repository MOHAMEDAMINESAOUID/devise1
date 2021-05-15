using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace le_devise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            string devise = " ";
            if(rbdollars.Checked)
            {
                m *= 0.12;
                devise = "Dollar";
            }
            else
            {
                if(radioButton2.Checked)
                {
                    m *= 0.09;
                    devise = "Euro";
                }
            }
            MessageBox.Show(textBox1.Text + "dh =" + m + devise);
        }
    }
}
