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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            int[] A = new int[Int32.Parse(textBox1.Text)];
            Random rnd = new Random();
            label1.Text += "|";
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(100);
                label1.Text += A[i].ToString()+"|";
            }
            int indexmax = 0; int indexmin = 0;
            int max = -1; int min = 101;
            int c;
            for (int i = 0;i < A.Length;i++)
            {
                if (A[i] > max) {  max = A[i]; indexmax = i; }
                if (A[i] < min) { min = A[i]; indexmin = i; }
            }
            c = A[indexmax]; A[indexmax] = A[indexmin]; A[indexmin] = c;
            label2.Text += "|";
            for (int i = 0;i<A.Length;i++)
            {
                label2.Text += A[i].ToString() + "|";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
