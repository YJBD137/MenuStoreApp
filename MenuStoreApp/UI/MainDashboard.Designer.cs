namespace MenuStoreApp
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            panelDashboard = new Panel();
            labelPosition = new Label();
            labelEmployeeName = new Label();
            buttonPOS = new Button();
            buttonConsignment = new Button();
            buttonInventory = new Button();
            menuDashboardLogo = new PictureBox();
            panelContents = new Panel();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).BeginInit();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.AutoScroll = true;
            panelDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.BackgroundImage = Properties.Resources.COLOR_BG;
            panelDashboard.Controls.Add(labelPosition);
            panelDashboard.Controls.Add(labelEmployeeName);
            panelDashboard.Controls.Add(buttonPOS);
            panelDashboard.Controls.Add(buttonConsignment);
            panelDashboard.Controls.Add(buttonInventory);
            panelDashboard.Controls.Add(menuDashboardLogo);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Margin = new Padding(3, 2, 3, 2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1664, 112);
            panelDashboard.TabIndex = 0;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(1418, 52);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(74, 18);
            labelPosition.TabIndex = 4;
            labelPosition.Text = "Position";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployeeName.ForeColor = Color.White;
            labelEmployeeName.Location = new Point(1418, 7);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(140, 18);
            labelEmployeeName.TabIndex = 0;
            labelEmployeeName.Text = "Employee Name";
            // 
            // buttonPOS
            // 
            buttonPOS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPOS.BackColor = Color.Transparent;
            buttonPOS.Dock = DockStyle.Left;
            buttonPOS.FlatAppearance.BorderSize = 0;
            buttonPOS.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPOS.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonPOS.FlatStyle = FlatStyle.Flat;
            buttonPOS.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPOS.ForeColor = Color.White;
            buttonPOS.Location = new Point(1019, 0);
            buttonPOS.Margin = new Padding(3, 2, 3, 2);
            buttonPOS.Name = "buttonPOS";
            buttonPOS.Size = new Size(394, 112);
            buttonPOS.TabIndex = 3;
            buttonPOS.Text = "Point of Sale";
            buttonPOS.UseVisualStyleBackColor = false;
            // 
            // buttonConsignment
            // 
            buttonConsignment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonConsignment.BackColor = Color.Transparent;
            buttonConsignment.Dock = DockStyle.Left;
            buttonConsignment.FlatAppearance.BorderSize = 0;
            buttonConsignment.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonConsignment.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonConsignment.FlatStyle = FlatStyle.Flat;
            buttonConsignment.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsignment.ForeColor = Color.White;
            buttonConsignment.Location = new Point(625, 0);
            buttonConsignment.Margin = new Padding(3, 2, 3, 2);
            buttonConsignment.Name = "buttonConsignment";
            buttonConsignment.Size = new Size(394, 112);
            buttonConsignment.TabIndex = 2;
            buttonConsignment.Text = "Consignment";
            buttonConsignment.UseVisualStyleBackColor = false;
            buttonConsignment.Click += buttonConsignment_Click;
            // 
            // buttonInventory
            // 
            buttonInventory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonInventory.BackColor = Color.Transparent;
            buttonInventory.Dock = DockStyle.Left;
            buttonInventory.FlatAppearance.BorderSize = 0;
            buttonInventory.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            buttonInventory.FlatStyle = FlatStyle.Flat;
            buttonInventory.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInventory.ForeColor = Color.White;
            buttonInventory.Location = new Point(231, 0);
            buttonInventory.Margin = new Padding(3, 2, 3, 2);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Size = new Size(394, 112);
            buttonInventory.TabIndex = 1;
            buttonInventory.Text = "Inventory";
            buttonInventory.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonInventory.UseVisualStyleBackColor = false;
            buttonInventory.Click += buttonInventory_Click;
            // 
            // menuDashboardLogo
            // 
            menuDashboardLogo.BackColor = Color.Transparent;
            menuDashboardLogo.BackgroundImage = (Image)resources.GetObject("menuDashboardLogo.BackgroundImage");
            menuDashboardLogo.BackgroundImageLayout = ImageLayout.Center;
            menuDashboardLogo.Dock = DockStyle.Left;
            menuDashboardLogo.Location = new Point(0, 0);
            menuDashboardLogo.Margin = new Padding(3, 2, 3, 2);
            menuDashboardLogo.Name = "menuDashboardLogo";
            menuDashboardLogo.Size = new Size(231, 112);
            menuDashboardLogo.TabIndex = 0;
            menuDashboardLogo.TabStop = false;
            // 
            // panelContents
            // 
            panelContents.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContents.BackColor = Color.White;
            panelContents.Dock = DockStyle.Fill;
            panelContents.Location = new Point(0, 112);
            panelContents.Margin = new Padding(3, 2, 3, 2);
            panelContents.Name = "panelContents";
            panelContents.Size = new Size(1664, 663);
            panelContents.TabIndex = 1;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1664, 775);
            Controls.Add(panelContents);
            Controls.Add(panelDashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            TransparencyKey = Color.DimGray;
            WindowState = FormWindowState.Maximized;
            FormClosed += MainDashboard_FormClosed;
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuDashboardLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDashboard;
        private Panel panelContents;
        private PictureBox menuDashboardLogo;
        private Button buttonInventory;
        private Button buttonPOS;
        private Button buttonConsignment;
        private Label labelEmployeeName;
        private Label labelPosition;
    }
}