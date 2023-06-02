using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeLacedItApp
{
    public partial class Financial : UserControl
    {
        DatabaseAccess access = null;
        public Financial(DatabaseAccess access)
        {
            InitializeComponent();

            this.access = access;
        }

        private void Financial_Load(object sender, EventArgs e)
        {
            DataTable Consign = access.GetTable("FINANCES");
            FinCons.DataSource = Consign;

            DataTable Sale = access.GetTable("SALES");
            FinSales.DataSource = Sale;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void databaseAccessBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void databaseAccessBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
