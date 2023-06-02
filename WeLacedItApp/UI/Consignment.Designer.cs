using WeLacedItApp.Properties;

namespace WeLacedItApp
{
    partial class Consignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consignment));
            panelSearch = new Panel();
            textBoxSearchInput = new TextBox();
            pictureBoxSearch = new PictureBox();
            buttonAddConsignor = new Button();
            ConsignorView = new DataGridView();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConsignorView).BeginInit();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(192, 254, 204);
            panelSearch.Controls.Add(textBoxSearchInput);
            panelSearch.Controls.Add(pictureBoxSearch);
            panelSearch.Controls.Add(buttonAddConsignor);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(4, 3, 4, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(779, 43);
            panelSearch.TabIndex = 1;
            panelSearch.TabStop = true;
            // 
            // textBoxSearchInput
            // 
            textBoxSearchInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchInput.BackColor = Color.FromArgb(192, 254, 204);
            textBoxSearchInput.BorderStyle = BorderStyle.None;
            textBoxSearchInput.Font = new Font("Verdana", 28F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchInput.Location = new Point(48, 0);
            textBoxSearchInput.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchInput.Name = "textBoxSearchInput";
            textBoxSearchInput.PlaceholderText = "Name or Consignor ID";
            textBoxSearchInput.Size = new Size(537, 46);
            textBoxSearchInput.TabIndex = 2;
            textBoxSearchInput.TextChanged += textBoxSearchInput_TextChanged;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackgroundImage = (Image)resources.GetObject("pictureBoxSearch.BackgroundImage");
            pictureBoxSearch.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSearch.Dock = DockStyle.Left;
            pictureBoxSearch.Location = new Point(0, 0);
            pictureBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(52, 43);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSearch.TabIndex = 4;
            pictureBoxSearch.TabStop = false;
            // 
            // buttonAddConsignor
            // 
            buttonAddConsignor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddConsignor.BackColor = Color.Transparent;
            buttonAddConsignor.Dock = DockStyle.Right;
            buttonAddConsignor.FlatAppearance.BorderColor = Color.FromArgb(192, 254, 204);
            buttonAddConsignor.FlatAppearance.BorderSize = 2;
            buttonAddConsignor.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 211, 254);
            buttonAddConsignor.FlatStyle = FlatStyle.Flat;
            buttonAddConsignor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddConsignor.ImageAlign = ContentAlignment.MiddleRight;
            buttonAddConsignor.Location = new Point(586, 0);
            buttonAddConsignor.Margin = new Padding(3, 2, 3, 2);
            buttonAddConsignor.Name = "buttonAddConsignor";
            buttonAddConsignor.Size = new Size(193, 43);
            buttonAddConsignor.TabIndex = 2;
            buttonAddConsignor.Text = "Add Consignor";
            buttonAddConsignor.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddConsignor.UseVisualStyleBackColor = false;
            buttonAddConsignor.Click += buttonAddConsignor_Click;
            // 
            // ConsignorView
            // 
            ConsignorView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConsignorView.Dock = DockStyle.Fill;
            ConsignorView.Location = new Point(0, 43);
            ConsignorView.Name = "ConsignorView";
            ConsignorView.RowTemplate.Height = 25;
            ConsignorView.Size = new Size(779, 413);
            ConsignorView.TabIndex = 2;
            // 
            // Consignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ConsignorView);
            Controls.Add(panelSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Consignment";
            Size = new Size(779, 456);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConsignorView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private Button buttonAddConsignor;
        private TextBox textBoxSearchInput;
        private PictureBox pictureBoxSearch;
        private DataGridView ConsignorView;
    }
}
