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
            this.components = new System.ComponentModel.Container();
            this.outputDisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backspace = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clearBttn = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSubtract = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bMutiply = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bDecimal = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputDisplay
            // 
            this.outputDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDisplay.Location = new System.Drawing.Point(12, 3);
            this.outputDisplay.Multiline = true;
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(258, 36);
            this.outputDisplay.TabIndex = 0;
            this.outputDisplay.Text = "0";
            this.outputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outputDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backspace.Location = new System.Drawing.Point(12, 54);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(60, 60);
            this.backspace.TabIndex = 2;
            this.backspace.Text = "⌫ ";
            this.backspace.UseVisualStyleBackColor = false;
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mod.Location = new System.Drawing.Point(210, 54);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(60, 60);
            this.mod.TabIndex = 3;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.Operator);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(144, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // clearBttn
            // 
            this.clearBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBttn.Location = new System.Drawing.Point(78, 54);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(60, 60);
            this.clearBttn.TabIndex = 5;
            this.clearBttn.Text = "C";
            this.clearBttn.UseVisualStyleBackColor = false;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b5.Location = new System.Drawing.Point(78, 186);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(60, 60);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b4.Location = new System.Drawing.Point(12, 186);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(60, 60);
            this.b4.TabIndex = 7;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b8.Location = new System.Drawing.Point(78, 120);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(60, 60);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b7.Location = new System.Drawing.Point(12, 120);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(60, 60);
            this.b7.TabIndex = 9;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b6.Location = new System.Drawing.Point(144, 186);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(60, 60);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b9.Location = new System.Drawing.Point(144, 120);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(60, 60);
            this.b9.TabIndex = 11;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.NumberClicked);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAdd.Location = new System.Drawing.Point(210, 120);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(60, 60);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.Operator);
            // 
            // bSubtract
            // 
            this.bSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubtract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSubtract.Location = new System.Drawing.Point(210, 186);
            this.bSubtract.Name = "bSubtract";
            this.bSubtract.Size = new System.Drawing.Size(60, 60);
            this.bSubtract.TabIndex = 13;
            this.bSubtract.Text = "-";
            this.bSubtract.UseVisualStyleBackColor = false;
            this.bSubtract.Click += new System.EventHandler(this.Operator);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b1.Location = new System.Drawing.Point(12, 252);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 60);
            this.b1.TabIndex = 14;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b2.Location = new System.Drawing.Point(78, 252);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(60, 60);
            this.b2.TabIndex = 15;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b3.Location = new System.Drawing.Point(144, 252);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 60);
            this.b3.TabIndex = 16;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.NumberClicked);
            // 
            // bMutiply
            // 
            this.bMutiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bMutiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMutiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMutiply.Location = new System.Drawing.Point(210, 252);
            this.bMutiply.Name = "bMutiply";
            this.bMutiply.Size = new System.Drawing.Size(60, 60);
            this.bMutiply.TabIndex = 17;
            this.bMutiply.Text = "*";
            this.bMutiply.UseVisualStyleBackColor = false;
            this.bMutiply.Click += new System.EventHandler(this.Operator);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b0.Location = new System.Drawing.Point(12, 318);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(60, 60);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.NumberClicked);
            // 
            // bDecimal
            // 
            this.bDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDecimal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDecimal.Location = new System.Drawing.Point(78, 318);
            this.bDecimal.Name = "bDecimal";
            this.bDecimal.Size = new System.Drawing.Size(60, 60);
            this.bDecimal.TabIndex = 19;
            this.bDecimal.Text = ".";
            this.bDecimal.UseVisualStyleBackColor = false;
            this.bDecimal.Click += new System.EventHandler(this.NumberClicked);
            // 
            // bEqual
            // 
            this.bEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEqual.Location = new System.Drawing.Point(144, 318);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(60, 60);
            this.bEqual.TabIndex = 20;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = false;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // bDivide
            // 
            this.bDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDivide.Location = new System.Drawing.Point(210, 318);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(60, 60);
            this.bDivide.TabIndex = 21;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = false;
            this.bDivide.Click += new System.EventHandler(this.Operator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(282, 380);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.bDecimal);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bMutiply);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bSubtract);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.outputDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button clearBttn;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSubtract;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bMutiply;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bDecimal;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button bDivide;
    }
}

