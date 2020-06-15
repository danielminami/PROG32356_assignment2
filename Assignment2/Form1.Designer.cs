namespace Assignment2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputDisplay = new System.Windows.Forms.TextBox();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnAbsolute = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnExponential = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnDecimalLogarithm = new System.Windows.Forms.Button();
            this.btnNaturalLogarithm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputDisplay
            // 
            this.outputDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDisplay.Location = new System.Drawing.Point(16, 13);
            this.outputDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.outputDisplay.Multiline = true;
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(519, 43);
            this.outputDisplay.TabIndex = 0;
            this.outputDisplay.Text = "0";
            this.outputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSquareRoot.Location = new System.Drawing.Point(367, 151);
            this.btnSquareRoot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(80, 74);
            this.btnSquareRoot.TabIndex = 2;
            this.btnSquareRoot.Tag = "sqrt";
            this.btnSquareRoot.Text = "√n";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMemoryRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryRecall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemoryRecall.Location = new System.Drawing.Point(191, 69);
            this.btnMemoryRecall.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(80, 74);
            this.btnMemoryRecall.TabIndex = 3;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = false;
            this.btnMemoryRecall.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMemoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemoryAdd.Location = new System.Drawing.Point(15, 69);
            this.btnMemoryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(80, 74);
            this.btnMemoryAdd.TabIndex = 4;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = false;
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScreen.ForeColor = System.Drawing.Color.White;
            this.btnClearScreen.Location = new System.Drawing.Point(279, 69);
            this.btnClearScreen.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(80, 74);
            this.btnClearScreen.TabIndex = 5;
            this.btnClearScreen.Text = "C";
            this.btnClearScreen.UseVisualStyleBackColor = false;
            this.btnClearScreen.Click += new System.EventHandler(this.ClearBttn_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b5.Location = new System.Drawing.Point(103, 233);
            this.b5.Margin = new System.Windows.Forms.Padding(4);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(80, 74);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.Number_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b4.Location = new System.Drawing.Point(15, 233);
            this.b4.Margin = new System.Windows.Forms.Padding(4);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(80, 74);
            this.b4.TabIndex = 7;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.Number_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b8.Location = new System.Drawing.Point(103, 152);
            this.b8.Margin = new System.Windows.Forms.Padding(4);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(80, 74);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.Number_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b7.Location = new System.Drawing.Point(15, 152);
            this.b7.Margin = new System.Windows.Forms.Padding(4);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(80, 74);
            this.b7.TabIndex = 9;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.Number_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b6.Location = new System.Drawing.Point(191, 233);
            this.b6.Margin = new System.Windows.Forms.Padding(4);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(80, 74);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.Number_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b9.Location = new System.Drawing.Point(191, 152);
            this.b9.Margin = new System.Windows.Forms.Padding(4);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(80, 74);
            this.b9.TabIndex = 11;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddition.Location = new System.Drawing.Point(279, 152);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(80, 74);
            this.btnAddition.TabIndex = 12;
            this.btnAddition.Tag = "+";
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtraction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubtraction.Location = new System.Drawing.Point(279, 233);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(80, 74);
            this.btnSubtraction.TabIndex = 13;
            this.btnSubtraction.Tag = "-";
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.Click += new System.EventHandler(this.Operator_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b1.Location = new System.Drawing.Point(15, 314);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(80, 74);
            this.b1.TabIndex = 14;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.Number_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b2.Location = new System.Drawing.Point(103, 314);
            this.b2.Margin = new System.Windows.Forms.Padding(4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(80, 74);
            this.b2.TabIndex = 15;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.Number_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b3.Location = new System.Drawing.Point(191, 314);
            this.b3.Margin = new System.Windows.Forms.Padding(4);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(80, 74);
            this.b3.TabIndex = 16;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMultiplication.Location = new System.Drawing.Point(279, 314);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(80, 74);
            this.btnMultiplication.TabIndex = 17;
            this.btnMultiplication.Tag = "*";
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.Operator_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b0.Location = new System.Drawing.Point(15, 395);
            this.b0.Margin = new System.Windows.Forms.Padding(4);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(80, 74);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.Number_Click);
            // 
            // bDecimal
            // 
            this.bDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDecimal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDecimal.Location = new System.Drawing.Point(103, 395);
            this.bDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.bDecimal.Name = "bDecimal";
            this.bDecimal.Size = new System.Drawing.Size(80, 74);
            this.bDecimal.TabIndex = 19;
            this.bDecimal.Text = ".";
            this.bDecimal.UseVisualStyleBackColor = false;
            this.bDecimal.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEqual.Location = new System.Drawing.Point(191, 395);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(80, 74);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.Equal_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivision.Location = new System.Drawing.Point(279, 395);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(80, 74);
            this.btnDivision.TabIndex = 21;
            this.btnDivision.Tag = "/";
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnAbsolute
            // 
            this.btnAbsolute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAbsolute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsolute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbsolute.Location = new System.Drawing.Point(455, 395);
            this.btnAbsolute.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbsolute.Name = "btnAbsolute";
            this.btnAbsolute.Size = new System.Drawing.Size(80, 74);
            this.btnAbsolute.TabIndex = 25;
            this.btnAbsolute.Tag = "ABS";
            this.btnAbsolute.Text = "|n|";
            this.btnAbsolute.UseVisualStyleBackColor = false;
            this.btnAbsolute.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFactorial.Location = new System.Drawing.Point(455, 313);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(80, 74);
            this.btnFactorial.TabIndex = 24;
            this.btnFactorial.Tag = "FACT";
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModulus.Location = new System.Drawing.Point(367, 69);
            this.btnModulus.Margin = new System.Windows.Forms.Padding(4);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(80, 74);
            this.btnModulus.TabIndex = 23;
            this.btnModulus.Tag = "mod";
            this.btnModulus.Text = "Mod";
            this.btnModulus.UseVisualStyleBackColor = false;
            this.btnModulus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemoryClear.Location = new System.Drawing.Point(103, 69);
            this.btnMemoryClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(80, 74);
            this.btnMemoryClear.TabIndex = 22;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = false;
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReciprocal.Location = new System.Drawing.Point(367, 395);
            this.btnReciprocal.Margin = new System.Windows.Forms.Padding(4);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(80, 74);
            this.btnReciprocal.TabIndex = 30;
            this.btnReciprocal.Tag = "inv";
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = false;
            this.btnReciprocal.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnExponential
            // 
            this.btnExponential.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExponential.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponential.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExponential.Location = new System.Drawing.Point(367, 314);
            this.btnExponential.Margin = new System.Windows.Forms.Padding(4);
            this.btnExponential.Name = "btnExponential";
            this.btnExponential.Size = new System.Drawing.Size(80, 74);
            this.btnExponential.TabIndex = 29;
            this.btnExponential.Tag = "exp";
            this.btnExponential.Text = "Exp";
            this.btnExponential.UseVisualStyleBackColor = false;
            this.btnExponential.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPower.Location = new System.Drawing.Point(367, 233);
            this.btnPower.Margin = new System.Windows.Forms.Padding(4);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(80, 74);
            this.btnPower.TabIndex = 28;
            this.btnPower.Tag = "pow";
            this.btnPower.Text = "nˣ";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBackspace.Location = new System.Drawing.Point(455, 69);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(80, 74);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "⌫ ";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // btnDecimalLogarithm
            // 
            this.btnDecimalLogarithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDecimalLogarithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalLogarithm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDecimalLogarithm.Location = new System.Drawing.Point(455, 152);
            this.btnDecimalLogarithm.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecimalLogarithm.Name = "btnDecimalLogarithm";
            this.btnDecimalLogarithm.Size = new System.Drawing.Size(80, 74);
            this.btnDecimalLogarithm.TabIndex = 28;
            this.btnDecimalLogarithm.Tag = "log";
            this.btnDecimalLogarithm.Text = "Log";
            this.btnDecimalLogarithm.UseVisualStyleBackColor = false;
            this.btnDecimalLogarithm.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnNaturalLogarithm
            // 
            this.btnNaturalLogarithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNaturalLogarithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaturalLogarithm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNaturalLogarithm.Location = new System.Drawing.Point(455, 233);
            this.btnNaturalLogarithm.Margin = new System.Windows.Forms.Padding(4);
            this.btnNaturalLogarithm.Name = "btnNaturalLogarithm";
            this.btnNaturalLogarithm.Size = new System.Drawing.Size(80, 74);
            this.btnNaturalLogarithm.TabIndex = 29;
            this.btnNaturalLogarithm.Tag = "ln";
            this.btnNaturalLogarithm.Text = "Ln";
            this.btnNaturalLogarithm.UseVisualStyleBackColor = false;
            this.btnNaturalLogarithm.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(553, 482);
            this.Controls.Add(this.btnNaturalLogarithm);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnDecimalLogarithm);
            this.Controls.Add(this.btnExponential);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnAbsolute);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.bDecimal);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.btnClearScreen);
            this.Controls.Add(this.btnMemoryAdd);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.outputDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputDisplay;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bDecimal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnAbsolute;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnExponential;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnDecimalLogarithm;
        private System.Windows.Forms.Button btnNaturalLogarithm;
    }
}

