namespace CalculatorApplication
{
    partial class frmCalculator
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
            label1 = new Label();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            label2 = new Label();
            cbOperator = new ComboBox();
            label3 = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 12F);
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(149, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(224, 20);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(111, 26);
            txtBoxInput1.TabIndex = 1;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(224, 105);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(111, 26);
            txtBoxInput2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 12F);
            label2.Location = new Point(19, 105);
            label2.Name = "label2";
            label2.Size = new Size(167, 19);
            label2.TabIndex = 3;
            label2.Text = "Enter Second Number:";
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(225, 61);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(110, 27);
            cbOperator.TabIndex = 4;
            cbOperator.Tag = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 12F);
            label3.Location = new Point(120, 172);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 5;
            label3.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Consolas", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDisplayTotal.Location = new Point(225, 172);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(117, 19);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "------------";
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ActiveCaption;
            btnEqual.FlatStyle = FlatStyle.Popup;
            btnEqual.Font = new Font("Lucida Sans Typewriter", 14F);
            btnEqual.Location = new Point(216, 230);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(126, 37);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 358);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label3);
            Controls.Add(cbOperator);
            Controls.Add(label2);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private Label label2;
        private ComboBox cbOperator;
        private Label label3;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}
