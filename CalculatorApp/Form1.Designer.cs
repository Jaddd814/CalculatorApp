namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnClear = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(19, 62);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(216, 68);
            txtDisplay.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(19, 136);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 69);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(93, 136);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 69);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(167, 136);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 69);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(19, 211);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 69);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(93, 211);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 69);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(167, 211);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 69);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(19, 286);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 69);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(93, 286);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 69);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(167, 286);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 69);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(19, 361);
            btn10.Name = "btn10";
            btn10.Size = new Size(68, 69);
            btn10.TabIndex = 11;
            btn10.Text = "0";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += NumberButton_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(93, 361);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(68, 69);
            btnDecimal.TabIndex = 12;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(167, 361);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(68, 69);
            btnEquals.TabIndex = 13;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(241, 136);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(68, 69);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += OperatorButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(241, 211);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(68, 69);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += OperatorButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(241, 286);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(68, 69);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += OperatorButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(241, 361);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(68, 69);
            btnPlus.TabIndex = 17;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += OperatorButton_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(241, 62);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(68, 69);
            btnClear.TabIndex = 18;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(19, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(76, 20);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnClear);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btnDecimal;
        private Button btnEquals;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnClear;
        private Label lblTitle;
    }
}
