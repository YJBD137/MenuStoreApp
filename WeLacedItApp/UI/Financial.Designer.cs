namespace WeLacedItApp
{
    partial class Financial
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financial));
            FinCons = new DataGridView();
            databaseAccessBindingSource = new BindingSource(components);
            FinSales = new DataGridView();
            databaseAccessBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)FinCons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseAccessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FinSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseAccessBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // FinCons
            // 
            FinCons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(FinCons, "FinCons");
            FinCons.Name = "FinCons";
            FinCons.RowTemplate.Height = 25;
            // 
            // databaseAccessBindingSource
            // 
            databaseAccessBindingSource.DataSource = typeof(DatabaseAccess);
            databaseAccessBindingSource.CurrentChanged += databaseAccessBindingSource_CurrentChanged;
            // 
            // FinSales
            // 
            FinSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(FinSales, "FinSales");
            FinSales.Name = "FinSales";
            FinSales.RowTemplate.Height = 25;
            FinSales.CellContentClick += dataGridView2_CellContentClick;
            // 
            // databaseAccessBindingSource1
            // 
            databaseAccessBindingSource1.AllowNew = false;
            databaseAccessBindingSource1.DataSource = typeof(DatabaseAccess);
            databaseAccessBindingSource1.CurrentChanged += databaseAccessBindingSource1_CurrentChanged;
            // 
            // Financial
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 235, 192);
            Controls.Add(FinSales);
            Controls.Add(FinCons);
            Name = "Financial";
            Load += Financial_Load;
            ((System.ComponentModel.ISupportInitialize)FinCons).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseAccessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)FinSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseAccessBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView FinCons;
        private BindingSource databaseAccessBindingSource;
        private DataGridView FinSales;
        private BindingSource databaseAccessBindingSource1;
    }
}
