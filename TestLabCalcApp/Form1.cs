using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLabCalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = "0";
            this.label2.Text = "";
            this.label3.Text = "";
        }

        private double GetLabel1Double()
        {
            double res = 0;
            try
            {
                res = Convert.ToDouble(this.label1.Text);
            } catch
            {
                res = 0;
            }
            return res;
        }

        private void buttonNum_Click(int num)
        {
            var res = GetLabel1Double();
            res *= 10;
            if (res >= 0) res += num;
            else res -= num;
            this.label1.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonNum_Click(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonNum_Click(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonNum_Click(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonNum_Click(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonNum_Click(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonNum_Click(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonNum_Click(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonNum_Click(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonNum_Click(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonNum_Click(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            this.label3.Text = "mult";
            this.label2.Text = GetLabel1Double().ToString();
            this.label1.Text = "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            this.label3.Text = "div";
            this.label2.Text = GetLabel1Double().ToString();
            this.label1.Text = "0";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            this.label3.Text = "sub";
            this.label2.Text = GetLabel1Double().ToString();
            this.label1.Text = "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.label3.Text = "add";
            this.label2.Text = GetLabel1Double().ToString();
            this.label1.Text = "0";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            var op_type = this.label3.Text;
            double res=0;
            bool except = false;
            switch(op_type)
            {
                case "add":
                    res = Calculator.Add(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    break;
                case "sub":
                    res = Calculator.Sub(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    break;
                case "mult":
                    res = Calculator.Mult(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    break;
                case "div":
                    try
                    {
                        res = Calculator.Div(Convert.ToDouble(this.label2.Text), Convert.ToDouble(this.label1.Text));
                    } catch(DivideByZeroException)
                    {
                        except = true;
                    }
                    break;
                case "":
                    res = 0;
                    break;
            }
            if (except)
                this.label1.Text = "Error: Division By Zero";
            else
                this.label1.Text = res.ToString();
            this.label2.Text = "";
            this.label3.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var res = GetLabel1Double();
            res = (res - res%10)/10;
            this.label1.Text = res.ToString();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
            this.label2.Text = "";
            this.label3.Text = "";
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            var res = -GetLabel1Double();
            this.label1.Text = res.ToString();
        }
    }
}
