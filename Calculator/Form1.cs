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
            dddddddd("+");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dddddddd("-");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dddddddd("*");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cccccccc("sqrt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cccccccc("sin");       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dddddddd("x^y");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            cccccccc("cos");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cccccccc("tg");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cccccccc("ctg");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cccccccc("ln10");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cccccccc("ln");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cccccccc("asin");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cccccccc("acos");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cccccccc("atg");
        }
        private void cccccccc(string calcName)
        {
            operation calc = MonoFabric.Calc(calcName);
            double x = Convert.ToDouble(textBox1.Text);
            textBox3.Text = calc.aaaaa(x).ToString();
        }
        private void dddddddd(string calcName)
        {
            BinaryOperation calc = fabric.Calc(calcName);
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox3.Text = calc.bbbbbb(x, y).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dddddddd("/");
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
