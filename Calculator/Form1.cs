using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc2("+");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Calc2("-");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calc2("*");
        }

        private void button6_Click(object sender, EventArgs e)
        {
             Calc1("sqrt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calc1("sin");       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calc2("x^y");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Calc1("cos");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calc1("tg");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Calc1("ctg");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calc1("ln10");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calc1("ln");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Calc1("asin");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Calc1("acos");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Calc1("atg");
        }
        private void Calc1(string calcName)
        {
            Operation calc = MonoFabric.Calc(calcName);
            double x = Convert.ToDouble(textBox1.Text);
            textBox3.Text = calc.Calculate(x).ToString();
        }
        private void Calc2(string calcName)
        {
            BinaryOperation calc = fabric.Calc(calcName);
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox3.Text = calc.Calculate(x, y).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calc2("/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
