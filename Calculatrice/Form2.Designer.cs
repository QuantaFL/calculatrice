namespace Calculatrice
{
    partial class frmAdvCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.btnScBasique = new System.Windows.Forms.Button();
            this.btnParenS = new System.Windows.Forms.Button();
            this.btnVirgule = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnParenE = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnRacine = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.memory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtOperator
            // 
            this.txtOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperator.Enabled = false;
            this.txtOperator.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperator.Location = new System.Drawing.Point(11, 118);
            this.txtOperator.Multiline = true;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(424, 36);
            this.txtOperator.TabIndex = 43;
            this.txtOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnScBasique
            // 
            this.btnScBasique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnScBasique.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScBasique.ForeColor = System.Drawing.Color.White;
            this.btnScBasique.Location = new System.Drawing.Point(270, 0);
            this.btnScBasique.Name = "btnScBasique";
            this.btnScBasique.Size = new System.Drawing.Size(165, 43);
            this.btnScBasique.TabIndex = 42;
            this.btnScBasique.Text = "Advanced";
            this.btnScBasique.UseVisualStyleBackColor = false;
            this.btnScBasique.Click += new System.EventHandler(this.btnScBasique_Click);
            // 
            // btnParenS
            // 
            this.btnParenS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnParenS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParenS.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParenS.ForeColor = System.Drawing.SystemColors.Control;
            this.btnParenS.Location = new System.Drawing.Point(184, 225);
            this.btnParenS.Name = "btnParenS";
            this.btnParenS.Size = new System.Drawing.Size(80, 60);
            this.btnParenS.TabIndex = 41;
            this.btnParenS.Text = "(";
            this.btnParenS.UseVisualStyleBackColor = false;
            this.btnParenS.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnVirgule
            // 
            this.btnVirgule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnVirgule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgule.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgule.ForeColor = System.Drawing.Color.White;
            this.btnVirgule.Location = new System.Drawing.Point(270, 490);
            this.btnVirgule.Name = "btnVirgule";
            this.btnVirgule.Size = new System.Drawing.Size(80, 60);
            this.btnVirgule.TabIndex = 40;
            this.btnVirgule.Text = ".";
            this.btnVirgule.UseVisualStyleBackColor = false;
            this.btnVirgule.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(356, 490);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(80, 60);
            this.btnResult.TabIndex = 39;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(98, 490);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(166, 60);
            this.btnZero.TabIndex = 38;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 60);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnParenE
            // 
            this.btnParenE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnParenE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParenE.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParenE.ForeColor = System.Drawing.Color.White;
            this.btnParenE.Location = new System.Drawing.Point(270, 225);
            this.btnParenE.Name = "btnParenE";
            this.btnParenE.Size = new System.Drawing.Size(80, 60);
            this.btnParenE.TabIndex = 36;
            this.btnParenE.Text = ")";
            this.btnParenE.UseVisualStyleBackColor = false;
            this.btnParenE.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(356, 424);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(80, 60);
            this.btnPlus.TabIndex = 35;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(356, 357);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(80, 60);
            this.btnMinus.TabIndex = 34;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnTimes
            // 
            this.btnTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimes.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.ForeColor = System.Drawing.Color.White;
            this.btnTimes.Location = new System.Drawing.Point(356, 291);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnTimes.Size = new System.Drawing.Size(80, 60);
            this.btnTimes.TabIndex = 33;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = false;
            this.btnTimes.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThree.Location = new System.Drawing.Point(270, 424);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(80, 60);
            this.btnThree.TabIndex = 32;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTwo.Location = new System.Drawing.Point(184, 424);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(80, 60);
            this.btnTwo.TabIndex = 31;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOne.Location = new System.Drawing.Point(98, 424);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 60);
            this.btnOne.TabIndex = 30;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSix.Location = new System.Drawing.Point(270, 357);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(80, 60);
            this.btnSix.TabIndex = 29;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFive.Location = new System.Drawing.Point(184, 357);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(80, 60);
            this.btnFive.TabIndex = 28;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFour.Location = new System.Drawing.Point(98, 357);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(80, 60);
            this.btnFour.TabIndex = 27;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(356, 225);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 60);
            this.btnDivide.TabIndex = 26;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNine.Location = new System.Drawing.Point(270, 291);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(80, 60);
            this.btnNine.TabIndex = 25;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEight.Location = new System.Drawing.Point(184, 291);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(80, 60);
            this.btnEight.TabIndex = 24;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeven.Location = new System.Drawing.Point(98, 291);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(80, 60);
            this.btnSeven.TabIndex = 23;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.BtnClick);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Enabled = false;
            this.txtBox.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(11, 150);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(424, 69);
            this.txtBox.TabIndex = 22;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(98, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 60);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Ce";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.Location = new System.Drawing.Point(12, 291);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(80, 60);
            this.btnE.TabIndex = 45;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnRacine
            // 
            this.btnRacine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRacine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacine.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacine.ForeColor = System.Drawing.Color.White;
            this.btnRacine.Location = new System.Drawing.Point(12, 424);
            this.btnRacine.Name = "btnRacine";
            this.btnRacine.Size = new System.Drawing.Size(80, 60);
            this.btnRacine.TabIndex = 47;
            this.btnRacine.Text = "√";
            this.btnRacine.UseVisualStyleBackColor = false;
            this.btnRacine.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnX2
            // 
            this.btnX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.ForeColor = System.Drawing.Color.White;
            this.btnX2.Location = new System.Drawing.Point(12, 357);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(80, 60);
            this.btnX2.TabIndex = 46;
            this.btnX2.Text = "x²";
            this.btnX2.UseVisualStyleBackColor = false;
            this.btnX2.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnFact
            // 
            this.btnFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFact.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFact.ForeColor = System.Drawing.Color.White;
            this.btnFact.Location = new System.Drawing.Point(12, 490);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(80, 60);
            this.btnFact.TabIndex = 48;
            this.btnFact.Text = "!";
            this.btnFact.UseVisualStyleBackColor = false;
            this.btnFact.Click += new System.EventHandler(this.BtnClick);
            // 
            // memory
            // 
            this.memory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.memory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memory.ForeColor = System.Drawing.SystemColors.Window;
            this.memory.FormattingEnabled = true;
            this.memory.ItemHeight = 16;
            this.memory.Location = new System.Drawing.Point(10, 49);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(425, 64);
            this.memory.TabIndex = 49;
            // 
            // frmAdvCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(454, 585);
            this.ControlBox = false;
            this.Controls.Add(this.memory);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.btnRacine);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.btnScBasique);
            this.Controls.Add(this.btnParenS);
            this.Controls.Add(this.btnVirgule);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnParenE);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.txtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAdvCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdvClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Button btnScBasique;
        private System.Windows.Forms.Button btnParenS;
        private System.Windows.Forms.Button btnVirgule;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnParenE;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnRacine;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.ListBox memory;
    }
}