using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculatrice
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            txtBox.Text = string.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            BoxChanger('0');
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            var result = new System.Data.DataTable().Compute(txtBox.Text.Trim(), null);
            txtBox.Text = result.ToString();
        }

        private void btnZero_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            BoxChanger('1');
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            BoxChanger('2');
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            BoxChanger('3');
        }
        /// <summary>
        /// Ceci permet d'ajouter un caractere donnee au texte field
        /// </summary>
        /// <param name="character"></param>
        void BoxChanger(char character)
        {
            txtBox.Text = txtBox.Text.Trim()+ character;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            BoxChanger('7');
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            BoxChanger('5');
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            BoxChanger('4');
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            BoxChanger('6');
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            BoxChanger('8');
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            BoxChanger('9');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!(txtBox.Text.Equals(string.Empty) || IsOperator(txtBox.Text[txtBox.Text.Length - 1])))
            {
                BoxChanger('/');
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!(txtBox.Text.Equals(string.Empty) || IsOperator(txtBox.Text[txtBox.Text.Length - 1])))
            {
                BoxChanger('-');
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (!(txtBox.Text.Equals(string.Empty) || IsOperator(txtBox.Text[txtBox.Text.Length - 1])))
            {
                BoxChanger('*');
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!(txtBox.Text.Equals(string.Empty) || IsOperator(txtBox.Text[txtBox.Text.Length - 1])))
            {
                BoxChanger('+');
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Equals("0"))
            {
                txtBox.Text = txtBox.Text.Trim().Length > 0 ? txtBox.Text.Substring(0, txtBox.Text.Length - 1) : txtBox.Text;
                if (txtBox.Text.Equals(""))
                {
                    txtBox.Text = "0";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = string.Empty;
        }
        /// <summary>
        /// ceci verifie si le caractere est un operateur ou pas
        /// </summary>
        /// <param name="c"></param>
        /// <returns>retourne vrai si la valeur est un operateur sinon elle retourne faux</returns>
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-'|| c == '*' || c == '/';
        }
    }
}
