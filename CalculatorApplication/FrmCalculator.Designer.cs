namespace CalculatorApplication
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
            comboBoxoperators = new ComboBox();
            txtinput1 = new TextBox();
            txtinput2 = new TextBox();
            buttoncal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBoxoperators
            // 
            comboBoxoperators.FormattingEnabled = true;
            comboBoxoperators.Location = new Point(267, 84);
            comboBoxoperators.Name = "comboBoxoperators";
            comboBoxoperators.Size = new Size(71, 23);
            comboBoxoperators.TabIndex = 0;
            comboBoxoperators.Text = "operator";
            // 
            // txtinput1
            // 
            txtinput1.Location = new Point(238, 42);
            txtinput1.Name = "txtinput1";
            txtinput1.Size = new Size(100, 23);
            txtinput1.TabIndex = 1;
            // 
            // txtinput2
            // 
            txtinput2.Location = new Point(238, 128);
            txtinput2.Name = "txtinput2";
            txtinput2.Size = new Size(100, 23);
            txtinput2.TabIndex = 2;
            // 
            // buttoncal
            // 
            buttoncal.BackColor = Color.FromArgb(255, 128, 128);
            buttoncal.FlatStyle = FlatStyle.Popup;
            buttoncal.Location = new Point(238, 219);
            buttoncal.Name = "buttoncal";
            buttoncal.Size = new Size(88, 29);
            buttoncal.TabIndex = 3;
            buttoncal.Text = "CALCULATE";
            buttoncal.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 4;
            label1.Text = "ENTER FIRST NUMBER :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(210, 21);
            label2.TabIndex = 5;
            label2.Text = "ENTER SECOND NUMBER :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(192, 195);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 6;
            label3.Text = "______________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 195);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 7;
            label4.Text = "ANSWER :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 260);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttoncal);
            Controls.Add(txtinput2);
            Controls.Add(txtinput1);
            Controls.Add(comboBoxoperators);
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxoperators;
        private TextBox txtinput1;
        private TextBox txtinput2;
        private Button buttoncal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}