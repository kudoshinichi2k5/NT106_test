using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Calculator;
        float num1, num2;
        char option;
        float result;
        ///bool flag = true;      //check xem phep tinh co hop le ko


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = btn9.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //txtTotal.Text += btnPlus.Text;  
            option = '+';
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = '-';
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = '*';
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = '/';
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            option = '%';
            num1 = float.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = float.Parse(txtTotal.Text);
                switch (option)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        {
                            if (num2 == 0)
                                throw new DivideByZeroException();
                            else
                                result = num1 / num2;
                            break;
                        }
                    default:
                        result = num1 % num2;
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                txtTotal.Clear();
                txtTotal.Text = result + "";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
            {
                txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btnDot.Text;
            if (!txtTotal.Text.Contains("."))
            {
                if (txtTotal.Text == "")
                {
                    txtTotal.Text = "0.";
                }
                else
                {
                    txtTotal.Text += ".";
                }
            }
        }
    }
}
