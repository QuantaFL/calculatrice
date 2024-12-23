using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form2 : Form
    {
        static int temp = 0;
        static string operation = "";
        static int resultat=0;
        public Form2()
        {
            InitializeComponent();
            txtBox.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "1";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "2";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "3";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "4";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "5";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "6";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "7";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0"))
            {
                txtBox.Text = "8";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Equals("0")) {
                txtBox.Text = "9";
            }
            else
            {
                txtBox.Text = txtBox.Text.Trim() + "9";
            }
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Equals("0"))
            {
                txtBox.Text = txtBox.Text.Trim().Length > 0 ? txtBox.Text.Substring(0, txtBox.Text.Length - 1) : txtBox.Text;
                if (txtBox.Text.Equals("")){
                    txtBox.Text = "0";
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           // if (!(txtBox.Text.LastIndexOf('+') == txtBox.Text.Length - 1))
                if (operation.Equals("") || operation.Equals("+")){
                    operation = "+";
                    temp += int.Parse(txtBox.Text);//4//5
                    txtBox.Text = "0";
                }
                else
                {
                    
                    resultat = Operation(temp,int.Parse(txtBox.Text));
                    operation = "+";
                    txtBox.Text = "0";
                }
        }

        private void btnResultat_Click(object sender, EventArgs e)
        {
            temp = Operation(temp,int.Parse(txtBox.Text)) ;
            resultat = temp;
            txtBox.Text = resultat.ToString();
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            //op = -
                if (operation.Equals("") || operation.Equals("-"))
                {
                    operation = "-";
                    temp -= int.Parse(txtBox.Text);
                   txtBox.Text = "0";
                }//4 + 5 - 2
                else
                {
                    resultat = Operation(temp, int.Parse(txtBox.Text));
                    temp = resultat;
                    operation = "-";
                    txtBox.Text = "0";
                }
        }
        static int Operation(int num1, int num2)
        {
            if(operation.Equals("+"))
            {
                return num1 + num2;
            }
            else if (operation.Equals("-"))
            {
                return num1 - num2;
            }
            else if(operation.Equals("*"))
            {
                return num1 * num2;
            }
            else
            {
                return num1 / num2;
            }
        }

        private void btnFois_Click(object sender, EventArgs e)
        {

            if (operation.Equals("") || operation.Equals("*"))
            {
                if (operation.Equals(""))
                {
                    temp = 1;
                }
                operation = "*";
                temp *= int.Parse(txtBox.Text);
                txtBox.Text = "0";
            }//4 + 5 - 2
            else
            {
                resultat = Operation(temp, int.Parse(txtBox.Text));
                temp = resultat;
                operation = "*";
                txtBox.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operation.Equals("") || operation.Equals("/"))
            {
                if (operation == "/") {
                    temp = Operation(temp, int.Parse(txtBox.Text));
                }
                else
                {
                    temp = int.Parse(txtBox.Text);
                }

                operation = "/";
                txtBox.Text = "0";
            }//4 + 5 - 2
            else
            {
                resultat = Operation(temp, int.Parse(txtBox.Text));
                temp = resultat;
                operation = "/";
                txtBox.Text = "0";
            }
        }
    }
}
