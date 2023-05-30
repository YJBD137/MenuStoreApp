namespace WeLacedItApp
{
    partial class PointOfSale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCartDetails = new Panel();
            buttonPay = new Button();
            labelTotal = new Label();
            labelCart = new Label();
            pictureBox1 = new PictureBox();
            panelSearch = new Panel();
            textBoxSearchInput = new TextBox();
            pictureBoxSearch = new PictureBox();
            InvView = new DataGridView();
            panelCartDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvView).BeginInit();
            SuspendLayout();
            // 
            // panelCartDetails
            // 
            panelCartDetails.BackColor = Color.FromArgb(192, 254, 204);
            panelCartDetails.Controls.Add(buttonPay);
            panelCartDetails.Controls.Add(labelTotal);
            panelCartDetails.Controls.Add(labelCart);
            panelCartDetails.Controls.Add(pictureBox1);
            panelCartDetails.Dock = DockStyle.Right;
            panelCartDetails.Location = new Point(502, 0);
            panelCartDetails.Margin = new Padding(3, 2, 3, 2);
            panelCartDetails.Name = "panelCartDetails";
            panelCartDetails.Size = new Size(277, 456);
            panelCartDetails.TabIndex = 0;
            // 
            // buttonPay
            // 
            buttonPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 211, 254);
            buttonPay.Location = new Point(86, 362);
            buttonPay.Margin = new Padding(3, 2, 3, 2);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(107, 34);
            buttonPay.TabIndex = 2;
            buttonPay.Text = "Pay";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(5, 323);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(72, 23);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "Total: ";
            // 
            // labelCart
            // 
            labelCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelCart.Location = new Point(56, 4);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(92, 42);
            labelCart.TabIndex = 2;
            labelCart.Text = "Cart";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.icons8_shopping_cart_521;
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(192, 254, 204);
            panelSearch.Controls.Add(textBoxSearchInput);
            panelSearch.Controls.Add(pictureBoxSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(3, 2, 3, 2);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(502, 43);
            panelSearch.TabIndex = 1;
            // 
            // textBoxSearchInput
            // 
            textBoxSearchInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchInput.BackColor = Color.FromArgb(192, 254, 204);
            textBoxSearchInput.BorderStyle = BorderStyle.None;
            textBoxSearchInput.Font = new Font("Verdana", 28F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchInput.Location = new Point(51, 0);
            textBoxSearchInput.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchInput.Name = "textBoxSearchInput";
            textBoxSearchInput.PlaceholderText = "Brandname or SKU";
            textBoxSearchInput.Size = new Size(446, 46);
            textBoxSearchInput.TabIndex = 6;
            textBoxSearchInput.TextChanged += textBoxSearchInput_TextChanged;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackColor = Color.Transparent;
            pictureBoxSearch.Dock = DockStyle.Left;
            pictureBoxSearch.Image = Properties.Resources.icons8_search_52;
            pictureBoxSearch.Location = new Point(0, 0);
            pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(52, 43);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearch.TabIndex = 5;
            pictureBoxSearch.TabStop = false;
            // 
            // InvView
            // 
            InvView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvView.Dock = DockStyle.Fill;
            InvView.Location = new Point(0, 43);
            InvView.Name = "InvView";
            InvView.RowTemplate.Height = 25;
            InvView.Size = new Size(502, 413);
            InvView.TabIndex = 2;
            // 
            // PointOfSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(InvView);
            Controls.Add(panelSearch);
            Controls.Add(panelCartDetails);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PointOfSale";
            Size = new Size(779, 456);
            panelCartDetails.ResumeLayout(false);
            panelCartDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCartDetails;
        private Panel panelSearch;
        private PictureBox pictureBoxSearch;
        private TextBox textBoxSearchInput;
        private Label labelTotal;
        private Label labelCart;
        private PictureBox pictureBox1;
        private Button buttonPay;
        private DataGridView InvView;
    }
}
