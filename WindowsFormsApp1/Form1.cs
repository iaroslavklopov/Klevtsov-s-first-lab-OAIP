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
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double max = a;
            if (b > max)
            {
                max = b;
            }
            else
            {
                max = a;
            }
            if (c > max)
            {
                max = c;
            }
            else
            {
                max = max;
            }
            double min = a;
            if (b < min)
            {
                min = b;
            }
            else
            {
                min = a;
            }
            if (c < min)
            {
                min = c;
            }
            else
            {
                min = min;
            }
            double P = (max - min) / 2;
            label4.Text = P.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
           

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
