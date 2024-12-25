using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class frmAdvCalculator : Form
    {
        static List<String> list = new List<String>();
        public frmAdvCalculator(List<String> items)
        {
            InitializeComponent();
            txtBox.Text = string.Empty;
            foreach (String item in items)
            {
                memory.Items.Add(item);
            }
        }
        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text.Equals("Del"))
            {
                txtBox.Text = txtBox.Text.Trim().Length > 0 ? txtBox.Text.Substring(0, txtBox.Text.Length - 1) : txtBox.Text;
            }
            else if (btn.Text.Equals("Ce"))
            {
                txtBox.Text = String.Empty;
                txtOperator.Text = String.Empty;
                memory.Items.Clear();
            }
            else if (btn.Text.Equals("x²") || btn.Text.Equals("√") ||
                btn.Text.Equals("!") || btn.Text.Equals("e"))  // Changed from "e" to "e^x"
            {
                char op = btn.Text.Equals("x²") ? '²' : btn.Text[0];
                AdvOperation(op);
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
                    memory.Items.Add(calculate + " = " + result.ToString());
                    txtBox.Text = result.ToString();
                    txtOperator.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    txtBox.Text = "Memory Overflow";
                }
            }
        }
        private void btnScBasique_Click(object sender, EventArgs e)
        {
            foreach (String item in memory.Items)
            {
                list.Add(item);
            }
            new frmBasCalculator(list).Show();
            this.Hide();
        }

        private void FrmAdvClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// ceci verifie si le caractere est un operateur ou pas
        /// </summary>
        /// <param name="c"></param>
        /// <returns>retourne vrai si la valeur est un operateur sinon elle retourne faux</returns>
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '.' || c == '=';
        }
        /// <summary>
        /// Gere l'ajout de caracteres dans la zone de texte.
        /// </summary>
        /// <param name="character">Le caractere a ajouter (parenthese, operateur ou chiffre).</param>
        void BoxChanger(char character)
        {
            if (txtBox.Text.Equals("Memory Overflow")|| txtBox.Text.Equals("∞"))
            {
                ResetTextFields();
            }

            if (IsParenthesis(character))
            {
                HandleParentheses(character);
            }
            else
            {
                HandleSignOrNumber(character);
            }
        }

        /// <summary>
        /// Resets the text fields if memory overflow is encountered.
        /// </summary>
        private void ResetTextFields()
        {
            txtBox.Text = string.Empty;
            txtOperator.Text = string.Empty;
        }

        /// <summary>
        /// Verifie si le caractere est une parenthese.
        /// </summary>
        /// <param name="character">Le caractere à vérifier.</param>
        /// <returns>Retourne vrai si le caractere est une parenthese, sinon faux.</returns>
        private bool IsParenthesis(char character)
        {
            return character == '(' || character == ')';
        }

        /// <summary>
        /// Gère l'ajout des parenthèses dans la zone de texte.
        /// </summary>
        /// <param name="character">Le caractère parenthèse (ouvrante ou fermante) à ajouter.</param>
        private void HandleParentheses(char character)
        {
            if (character == '(')
            {
                AddOpeningParenthesis();
            }
            else if (character == ')')
            {
                AddClosingParenthesis();
            }
        }

        /// <summary>
        /// Ajoute une parenthèse ouvrante si les conditions sont remplies.
        /// </summary>
        private void AddOpeningParenthesis()
        {
            if (txtBox.Text.Length == 0 || IsOperator(txtBox.Text.Last()) || txtBox.Text.Last() == '(')
            {
                txtBox.Text += '(';
            }
        }

        /// <summary>
        /// Ajoute une parenthèse fermante si les conditions sont remplies.
        /// </summary>
        private void AddClosingParenthesis()
        {
            int openParenth = txtBox.Text.Count(c => c == '(');
            int closeParenth = txtBox.Text.Count(c => c == ')');

            if (openParenth > closeParenth)
            {
                if (txtBox.Text.Length > 0 && !IsOperator(txtBox.Text.Last()) && txtBox.Text.Last() != '(')
                {
                    txtBox.Text += ')';
                }
            }
        }

        /// <summary>
        /// Gère l'ajout des opérateurs et des chiffres dans la zone de texte.
        /// </summary>
        /// <param name="character">Le caractère à ajouter, soit un opérateur ou chiffre.</param>
        private void HandleSignOrNumber(char character)
        {
            if (IsOperator(character))
            {
                AddOperator(character);
            }
            else
            {
                AddNumber(character);
            }
        }

        /// <summary>
        /// Ajoute un operateur a la zone de texte ou a l'operateur selon les conditions
        /// </summary>
        /// <param name="character">operateur a ajouter</param>
        private void AddOperator(char character)
        {
            if (!string.IsNullOrEmpty(txtBox.Text) && !IsOperator(txtBox.Text.Last()) && txtBox.Text.Last() != '(')
            {
                int openParenth = txtBox.Text.Count(c => c == '(');
                int closeParenth = txtBox.Text.Count(c => c == ')');
                if(character.Equals('.'))
                {
                    txtBox.Text += ".";
                    return;
                }

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

        /// <summary>
        /// Ajoute un chiffre a la zone de texte.
        /// </summary>
        /// <param name="character">chiffre a ajouter</param>
        private void AddNumber(char character)
        {
            txtBox.Text += character;
        }

        /// <summary>
        /// Effectue des operation avancees selon L'Operateur fournie.
        /// </summary>
        /// <param name="operation">Operation à effectuer : '²', '√', '!', 'e'.</param>
        private void AdvOperation(char operation)
        {
            if (string.IsNullOrEmpty(txtBox.Text)) return;

            try
            {
                double val = ParseInput(txtBox.Text);

                double result = PerformOperation(operation, val);

                string resultText = FormatBigNumber(result);
                memory.Items.Add($"{val}{GetOperationText(operation)} = {resultText}");

                txtBox.Text = result.ToString();
                txtOperator.Text = string.Empty;
            }
            catch (Exception ex)
            {
                txtBox.Text = "Memory Overflow";
            }
        }

        /// <summary>
        /// Transforme l'entree en double
        /// </summary>
        /// <param name="input">Le texte</param>
        /// <returns>La valeur convertie.</returns>
        private double ParseInput(string input)
        {
            double val;
            if (!double.TryParse(input, out val))
            {
                txtBox.Text = "Memory Overflow";
            }
            return val;
        }

        /// <summary>
        /// Exécute l'opération mathématique avancée correspondant au caractère d'opération.
        /// </summary>
        /// <param name="operation">L'opération à exécuter.</param>
        /// <param name="val">La valeur à traiter.</param>
        /// <returns>Le résultat de l'opération.</returns>
        private double PerformOperation(char operation, double val)
        {
            double result = 0;

            switch (operation)
            {
                case '²':
                    result = Math.Pow(val, 2);
                    break;
                case '√':
                    if (val < 0) txtBox.Text = "Error";
                    result = Math.Sqrt(val);
                    break;
                case '!':
                    if (val < 0 || val != Math.Floor(val))
                        txtBox.Text = "Error";
                    if (val > 170)
                        txtBox.Text = "Memory Overflow";
                    result = FactRe(val);
                    break;
                case 'e':
                    result = Math.Exp(val);
                    break;
                default:
                    txtBox.Text = string.Empty;
                    txtOperator.Text = string.Empty;
                    break;
            }
            return result;
        }

        /// <summary>
        /// Retourne le texte en fonction de l'operateur.
        /// </summary>
        /// <param name="operation">l'operateur</param>
        /// <returns>Retourne L'operateur</returns>
        private string GetOperationText(char operation)
        {
            switch (operation)
            {
                case '²': return "²";
                case '√': return "√";
                case '!': return "!";
                case 'e': return "e";
                default: return string.Empty;
            }
        }

        /// <summary>
        /// Calcule la factorielle d'un nombre de maniere recursive.
        /// </summary>
        /// <param name="num">nombre a evaluer</param>
        /// <returns>(A Double precision Number) La factorielle du nombre</returns>
        private double FactRe(double num) => num < 2 ? 1 : num * FactRe(num - 1);

        /// <summary>
        /// Formate un nombre en notation scientifique si sa valeur est trop grande ou trop petite, sinon le retourne sous sa forme standard.
        /// </summary>
        /// <param name="number">Le nombre à formater.</param>
        /// <returns>Le nombre en notation scientifique ou standard.</returns>
        private string FormatBigNumber(double number)
        {
            if (Math.Abs(number) >= 1e10 || Math.Abs(number) <= 1e-10)
            {
                return number.ToString("e");
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
