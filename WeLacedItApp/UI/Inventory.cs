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
    public partial class Inventory : UserControl
    {
        DatabaseAccess access = null;
        public Inventory(DatabaseAccess access)
        {
            InitializeComponent();

            this.access = access;

            DataTable data = access.GetTable("INVENTORY");
            InvView.DataSource = data;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            addItem addItem = new addItem();
            addItem.ShowDialog();
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
