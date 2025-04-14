namespace Evaluator.UI.Windows
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
            txtdisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btndot = new Button();
            btn3 = new Button();
            btnminus = new Button();
            btnplus = new Button();
            btnmultiply = new Button();
            btnDivide = new Button();
            btnCloseparenthesis = new Button();
            btnResult = new Button();
            btnOpenparenthesis = new Button();
            btnPow = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtdisplay
            // 
            txtdisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdisplay.BackColor = Color.Gray;
            txtdisplay.Location = new Point(20, 16);
            txtdisplay.Name = "txtdisplay";
            txtdisplay.Size = new Size(381, 23);
            txtdisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(19, 52);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 50);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button1_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(76, 52);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 50);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(133, 52);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 50);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(20, 108);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 50);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(76, 164);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 50);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(19, 164);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 50);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(133, 108);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 50);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(76, 108);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 50);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(20, 220);
            btn0.Name = "btn0";
            btn0.Size = new Size(107, 50);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btndot
            // 
            btndot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndot.Location = new Point(133, 220);
            btndot.Name = "btndot";
            btndot.Size = new Size(51, 50);
            btndot.TabIndex = 11;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btndot_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(133, 164);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 50);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnminus
            // 
            btnminus.BackColor = Color.FromArgb(255, 128, 0);
            btnminus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnminus.Location = new Point(246, 164);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(51, 50);
            btnminus.TabIndex = 16;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += btnminus_Click;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.FromArgb(255, 128, 0);
            btnplus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnplus.Location = new Point(303, 164);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(108, 50);
            btnplus.TabIndex = 15;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += btnplus_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnmultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmultiply.Location = new Point(247, 108);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(51, 50);
            btnmultiply.TabIndex = 14;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = false;
            btnmultiply.Click += btnmultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(190, 108);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(51, 50);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnCloseparenthesis
            // 
            btnCloseparenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseparenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseparenthesis.Location = new Point(247, 52);
            btnCloseparenthesis.Name = "btnCloseparenthesis";
            btnCloseparenthesis.Size = new Size(51, 50);
            btnCloseparenthesis.TabIndex = 20;
            btnCloseparenthesis.Text = ")";
            btnCloseparenthesis.UseVisualStyleBackColor = false;
            btnCloseparenthesis.Click += btnCloseparenthesis_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(190, 220);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(221, 50);
            btnResult.TabIndex = 19;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnOpenparenthesis
            // 
            btnOpenparenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenparenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenparenthesis.Location = new Point(190, 52);
            btnOpenparenthesis.Name = "btnOpenparenthesis";
            btnOpenparenthesis.Size = new Size(51, 50);
            btnOpenparenthesis.TabIndex = 18;
            btnOpenparenthesis.Text = "(";
            btnOpenparenthesis.UseVisualStyleBackColor = false;
            btnOpenparenthesis.Click += btnOpenparenthesis_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(189, 164);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(51, 50);
            btnPow.TabIndex = 17;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(304, 108);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 50);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(304, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 50);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(413, 281);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnCloseparenthesis);
            Controls.Add(btnResult);
            Controls.Add(btnOpenparenthesis);
            Controls.Add(btnPow);
            Controls.Add(btnminus);
            Controls.Add(btnplus);
            Controls.Add(btnmultiply);
            Controls.Add(btnDivide);
            Controls.Add(btn3);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtdisplay);
            Name = "Form1";
            Text = "functions evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn0;
        private Button btndot;
        private Button btn3;
        private Button btnminus;
        private Button btnplus;
        private Button btnmultiply;
        private Button btnDivide;
        private Button btnCloseparenthesis;
        private Button btnResult;
        private Button btnOpenparenthesis;
        private Button btnPow;
        private Button btnClear;
        private Button btnDelete;
    }
}
