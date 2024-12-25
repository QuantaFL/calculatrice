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
using Button = System.Windows.Forms.Button;

namespace Calculatrice
{
    public partial class frmBasCalculator : Form
    {
        static string temp = string.Empty;
        static List<string> memory = new List<string>();
        public frmBasCalculator(List<String> items)
        {
            InitializeComponent();
            txtBox.Text = string.Empty;
            memory = new List<string>();
            foreach (String item in items) 
            { 
                memory.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text.Equals("Del"))
            {
                txtBox.Text = txtBox.Text.Trim().Length > 0 ? txtBox.Text.Substring(0, txtBox.Text.Length - 1) : txtBox.Text;
            }
            else
            {
               BoxChanger(btn.Text.ToString()[0]);
            }
            
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string calculate = string.Empty;
            if (!string.IsNullOrEmpty(txtOperator.Text) && !string.IsNullOrEmpty(txtBox.Text))
            {
                calculate = txtOperator.Text + txtBox.Text;
                try
                {
                    var result = new DataTable().Compute(calculate.Trim(), null);
                    memory.Add(calculate+" = "+result.ToString());
                    txtBox.Text = result.ToString();
                    txtOperator.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in calculation: " + ex.Message);
                }
            }
        }
        private void BtnBasSc(object sender, EventArgs e)
        {
            new frmAdvCalculator(memory).Show();
            this.Hide();
        }

        /// <summary>
        /// Gere l'ajout de caracteres dans la zone de texte.
        /// - Si le caractere est une parenthese ouvrante ou fermante, la fonction VerifParenth est utilisee pour verifier et ajouter la parenthese.
        /// - Sinon, la fonction SignsAndNumbers est utilisee pour ajouter un operateur ou un chiffre.
        /// </summary>
        /// <param name="character">Le caractere a ajouter (parenthese, operateur ou chiffre).</param>
        void BoxChanger(char character)
        {
            if (character == '(' || character == ')')
            {
                VerifParenth(character);
            }
            else
            {
                SignsAndNumbers(character);
            }
        }
        /// <summary>
        /// ceci verifie si le caractere est un operateur ou pas
        /// </summary>
        /// <param name="c"></param>
        /// <returns>retourne vrai si la valeur est un operateur sinon elle retourne faux</returns>
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-'|| c == '*' || c == '/' || c == '.'||c == '=';
        }

        /// <summary>
        /// Verifie et gere l'ajout des parentheses dans la zone de texte.
        /// - Si c'est une parenthese ouvrante '(', elle est ajoute si le champ est vide ou si le dernier caractere est un operateur ou une parenthese ouvrante.
        /// - Si c'est une parenthese fermante ')', elle est ajoute seulement si une parenthese ouvrante correspond et si le dernier caractere n'est pas un operateur ou une parenthese ouvrante.
        /// </summary>
        /// <param name="character">Le caractere parenthese (ouvrante ou fermante) a ajouter.</param>
        private void VerifParenth(char character)
        {
            if (character == '(')
            {
                if (txtBox.Text.Length == 0 || IsOperator(txtBox.Text.Last()) || txtBox.Text.Last() == '(')
                {
                    txtBox.Text += character;
                }
            }
            else if (character == ')')
            {
                int openParenth = txtBox.Text.Count(c => c == '(');
                int closeParenth = txtBox.Text.Count(c => c == ')');

                if (openParenth > closeParenth)
                {
                    if (txtBox.Text.Length > 0 && !IsOperator(txtBox.Text.Last()) && txtBox.Text.Last() != '(')
                    {
                        txtBox.Text += character;
                    }
                }
            }
        }
        /// <summary>
        /// Gere l'ajout des operateurs et des chiffres dans la zone de texte.
        /// Si un operateur est saisi, il est ajoute a txtBox ou txtOperator selon l'equilibre des parentheses.
        /// Les chiffres sont simplement ajoutes a txtBox.
        /// </summary>
        /// <param name="character">Le caractere a ajouter soit un operateur ou chiffre</param>
        private void SignsAndNumbers(char character)
        {
            if (IsOperator(character))
            {
                if (!string.IsNullOrEmpty(txtBox.Text) && !IsOperator(txtBox.Text.Last()) && txtBox.Text.Last() != '(')
                {
                    int openParenth = txtBox.Text.Count(c => c == '(');
                    int closeParenth = txtBox.Text.Count(c => c == ')');

                    if (openParenth > closeParenth)
                    {
                        txtBox.Text += character;
                    }
                    else
                    {
                        txtOperator.Text += txtBox.Text + character;
                        txtBox.Text = string.Empty;
                    }
                }
            }
            else
            {
                txtBox.Text += character;
            }
        }

        private void frmBas(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
