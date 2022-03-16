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
    public partial class Form3 : Form
    {
        double a, b, c, P, S;

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            if ((a < 0) || (b < 0) || (c < 0))
            {
                MessageBox.Show("Вычисление площади невозможно!");
                MessageBox.Show("Вычисление периметра невозможно!");
            }
            P = a + b + c;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            if (a <= 0 || b <= 0 || c <= 0)
            {
                label7.Text = "Erorr!";
                label8.Text = "Erorr!";
            }
            else
            {
                label7.Text = P.ToString();
                label8.Text = S.ToString();
            }
        }

        public Form3()
        {
            InitializeComponent();
        }
        
    }
         

}
