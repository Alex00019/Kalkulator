using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateTest(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            double result = 0.0;
            ITwoArgumentsCalculator Calculator = FactoryTwoArguments.CreateCalculate(((Button)sender).Name);
            result = Calculator.Calculate(first, second);
            textBox3.Text = result.ToString();
        }

        private void OneArgument(object sender, EventArgs e)
        {
            double argument = Convert.ToDouble(textBox1.Text);
            double result = 0.0;
            IOneArgumentsCalculator calculator = FactoryOneArgument.CreateCalculate(((Button)sender).Name);
            result = calculator.Calculate(argument);
            textBox3.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}