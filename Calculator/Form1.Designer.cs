namespace Calculator
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btnClear = new Button();
            btnDiv = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(37, 30);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(793, 174);
            txtTotal.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(37, 252);
            btn1.Name = "btn1";
            btn1.Size = new Size(134, 120);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(198, 252);
            btn2.Name = "btn2";
            btn2.Size = new Size(134, 120);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(366, 252);
            btn3.Name = "btn3";
            btn3.Size = new Size(134, 120);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(532, 252);
            btn4.Name = "btn4";
            btn4.Size = new Size(134, 120);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(696, 252);
            btn5.Name = "btn5";
            btn5.Size = new Size(134, 120);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(37, 419);
            btn6.Name = "btn6";
            btn6.Size = new Size(134, 120);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(198, 419);
            btn7.Name = "btn7";
            btn7.Size = new Size(134, 120);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(366, 419);
            btn8.Name = "btn8";
            btn8.Size = new Size(134, 120);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(532, 419);
            btn9.Name = "btn9";
            btn9.Size = new Size(134, 120);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(696, 419);
            btn0.Name = "btn0";
            btn0.Size = new Size(134, 120);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(37, 597);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(134, 120);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(198, 597);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(134, 120);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(366, 597);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(134, 120);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(532, 597);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(134, 120);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(696, 597);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 120);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEql
            // 
            btnEql.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEql.Location = new Point(37, 758);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(793, 120);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 916);
            Controls.Add(btnEql);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btn60;
        private Button btnClear;
        private Button btnDiv;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEql;
    }
}
