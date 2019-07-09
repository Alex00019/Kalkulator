using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_easy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double summa(double a, double b)
        {
            return a + b;
        }

        public static double raznost(double a, double b)
        {
            return a - b;
        }

        public static double umnogenie(double a, double b)
        {
            return a * b;
        }

        public static double delenie(double a, double b)
        {
            return a / b;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)   {   }

        private void textBox1_TextChanged(object sender, EventArgs e)   {   }

        private void label1_Click(object sender, EventArgs e)  {   }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(summa(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(raznost(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(umnogenie(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(delenie(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}