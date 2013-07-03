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
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            textBox3.Text = calc.bbbbbb(x,y).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
