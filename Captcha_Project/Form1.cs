using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "y", "z", "x", "q" };
            string[] sembol3 = { "#", "+", "-", "?" };
            int sembol4;

            Random random = new Random();
            int s1, s2, s3, s4;
            s1 = random.Next(0, sembol1.Length);
            s2 = random.Next(0, sembol2.Length);
            s3 = random.Next(0, sembol3.Length);
            s4 = random.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + s4.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text)
            {
                MessageBox.Show("Succesful.");
            }
            else
            {
                MessageBox.Show("Try Again.");
            }
        }
    }
}
