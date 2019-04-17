using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private int num1, num2, result;
        char operation;
        bool isFirstNum;

        private void ProcessInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void processInput(TextBox txtBox)
        {

            if (isFirstNum == true)
            {
                num1 = Convert.ToInt32(txtBox.Text);
            }
            else
            {
                num2 = Convert.ToInt32(txtBox.Text);
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            processInput(textBox1);
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            processInput(textBox1);
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            processInput(textBox1);
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            processInput(textBox1);
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            processInput(textBox1);
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            processInput(textBox1);
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            processInput(textBox1);
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            processInput(textBox1);
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            processInput(textBox1);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            operation = '+';
            isFirstNum = false;
            textBox1.Text = "";
        }

        private void BtnEq_Click(object sender, EventArgs e)
        {
            {

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;

                }

                textBox1.Text = String.Format("{0} {1} {2} = {3}", num1, operation, num2, result);
                //textBox1.Text = num1.ToString() + " " + operation + " " + num2.ToString() + " " + result.ToString();


            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            operation = '-';
            isFirstNum = false;
            textBox1.Text = "";
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            operation = '*';
            isFirstNum = false;
            textBox1.Text = "";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            operation = '/';
            isFirstNum = false;
            textBox1.Text = "";
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            isFirstNum = true;
            textBox1.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
            result = 0;
            isFirstNum = true;
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            processInput(textBox1);
        }
    }
}
