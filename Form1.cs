using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WindowsFormsApp1.Program;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReplaceOperation("???", label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplaceOperation('*', label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReplaceOperation('-', label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReplaceOperation('/', label1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //onPlusClicked();
            ReplaceOperation('+', label1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string operation = label1.Text.ToString();
            double parameter1 = System.Convert.ToDouble(textBox1.Text.ToString()); // if 6.5 instead of 6,5 - fail
            double parameter2 = System.Convert.ToDouble(textBox2.Text.ToString());
            switch (operation)
            {
                case "+":
                    printResult(Sum(parameter1, parameter2));
                    break;
                case "-":
                    printResult(Subtract(parameter1, parameter2));
                    break;
                case "*":
                    printResult(Multiply(parameter1, parameter2));
                    break;
                case "/":
                    printResult(Divide(parameter1, parameter2));
                    break;
                default:
                    // in error popup?
                    break;
            }
        }

        private void printResult(double result)
        {
            textBox3.Text = result.ToString();
        }
    }
}
