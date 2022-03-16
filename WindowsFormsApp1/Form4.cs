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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            Random rand = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            int max = 0; int min = 101;
            int maxindex = 0; int minindex = 0;
            int[,] A = new int[n, n];
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    A[i, j] = rand.Next(10, 99);
                    textBox2.Text += Convert.ToString(A[i, j]);
                    textBox2.Text += " ";
                    a[i, j] = A[i, j];
                }
                textBox2.Text += Environment.NewLine;


            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] > max) { max = A[i, j]; maxindex = i; }
                    if (A[i, j] < min) { min = A[i, j]; minindex = i; }
                }

            }
            for (int j = 0; j < n; j++)
            {
                a[minindex, j] = A[maxindex, j];
                a[maxindex, j] = A[minindex, j];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    textBox3.Text += Convert.ToString(a[i, j]);
                    textBox3.Text += " ";
                }
                textBox3.Text += Environment.NewLine;
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
