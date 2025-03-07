namespace PaymentManagment
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
            PaymentTypeLbl = new Label();
            amountLbl = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            PaymentButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // PaymentTypeLbl
            // 
            PaymentTypeLbl.AutoSize = true;
            PaymentTypeLbl.Location = new Point(250, 89);
            PaymentTypeLbl.Name = "PaymentTypeLbl";
            PaymentTypeLbl.Size = new Size(81, 15);
            PaymentTypeLbl.TabIndex = 0;
            PaymentTypeLbl.Text = "Payment Type";
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Location = new Point(280, 165);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(51, 15);
            amountLbl.TabIndex = 1;
            amountLbl.Text = "Amount";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(393, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(393, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // PaymentButton
            // 
            PaymentButton.Location = new Point(433, 225);
            PaymentButton.Name = "PaymentButton";
            PaymentButton.Size = new Size(81, 30);
            PaymentButton.TabIndex = 4;
            PaymentButton.Text = "Pay";
            PaymentButton.UseVisualStyleBackColor = true;
            PaymentButton.Click += PaymentButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 328);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(PaymentButton);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(amountLbl);
            Controls.Add(PaymentTypeLbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PaymentTypeLbl;
        private Label amountLbl;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button PaymentButton;
        private Label label3;
    }
}
