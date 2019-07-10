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

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }


        private void calkulate(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            double result = 0.0;
            ITwoArgumentsCalculator Calculator = Factory.Calculate(((Button)sender).Name);
            result = Calculator.Calculate(first, second);
            textBox3.Text = result.ToString();
        }
        private void DR(object sender, EventArgs e)
        {
            double one = Convert.ToDouble(textBox1.Text);
            double result = 0.0;
            Interface777 Calculator_2 = Factory_2.Calculate(((Button)sender).Name);
            result = Calculator_2.Calculate(one);
            textBox3.Text = result.ToString();
        }
    }
}