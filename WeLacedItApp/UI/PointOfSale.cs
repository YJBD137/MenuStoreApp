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
    public partial class PointOfSale : UserControl
    {

        DatabaseAccess access = null;
        public PointOfSale(DatabaseAccess access)
        {
            InitializeComponent();

            this.access = access;

            DataTable data = access.GetTable("INVENTORY");
            InvView.DataSource = data;

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.ShowDialog();
        }

        private void textBoxSearchInput_TextChanged(object sender, EventArgs e)
        {
           
            string str = "'" + textBoxSearchInput.Text + "'";

            DataTable data = access.GetTable("INVENTORY " +
                "WHERE ITEM_NAME LIKE" + str +
                "OR SKU LIKE " + str);
            InvView.DataSource = data;

        }
    }
}
