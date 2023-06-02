namespace WeLacedItApp
{
    partial class Pay
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
            comboBoxPaymentMethod = new ComboBox();
            textBoxAmountPaid = new TextBox();
            labelChange = new Label();
            labelAmountChange = new Label();
            buttonProceed = new Button();
            SuspendLayout();
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPaymentMethod.ForeColor = SystemColors.WindowFrame;
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Location = new Point(80, 27);
            comboBoxPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(293, 37);
            comboBoxPaymentMethod.TabIndex = 4;
            comboBoxPaymentMethod.Text = "Payment Type";
            // 
            // textBoxAmountPaid
            // 
            textBoxAmountPaid.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmountPaid.Location = new Point(80, 69);
            textBoxAmountPaid.Margin = new Padding(3, 2, 3, 2);
            textBoxAmountPaid.Name = "textBoxAmountPaid";
            textBoxAmountPaid.PlaceholderText = "Amount Paid";
            textBoxAmountPaid.Size = new Size(293, 37);
            textBoxAmountPaid.TabIndex = 5;
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelChange.ForeColor = SystemColors.WindowText;
            labelChange.Location = new Point(80, 107);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(114, 29);
            labelChange.TabIndex = 6;
            labelChange.Text = "Change:";
            // 
            // labelAmountChange
            // 
            labelAmountChange.AutoSize = true;
            labelAmountChange.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmountChange.Location = new Point(210, 107);
            labelAmountChange.Name = "labelAmountChange";
            labelAmountChange.Size = new Size(27, 29);
            labelAmountChange.TabIndex = 7;
            labelAmountChange.Text = "₱";
            // 
            // buttonProceed
            // 
            buttonProceed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonProceed.BackColor = Color.FromArgb(192, 211, 254);
            buttonProceed.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProceed.ForeColor = Color.Black;
            buttonProceed.Location = new Point(123, 165);
            buttonProceed.Margin = new Padding(3, 2, 3, 2);
            buttonProceed.Name = "buttonProceed";
            buttonProceed.Size = new Size(200, 57);
            buttonProceed.TabIndex = 0;
            buttonProceed.Text = "Proceed";
            buttonProceed.UseVisualStyleBackColor = false;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(466, 267);
            Controls.Add(buttonProceed);
            Controls.Add(labelAmountChange);
            Controls.Add(labelChange);
            Controls.Add(textBoxAmountPaid);
            Controls.Add(comboBoxPaymentMethod);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxPaymentMethod;
        private TextBox textBoxAmountPaid;
        private Label labelChange;
        private Label labelAmountChange;
        private Button buttonProceed;
    }
}