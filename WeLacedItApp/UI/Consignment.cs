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
    public partial class Consignment : UserControl
    {

        DatabaseAccess access = null;
        public Consignment(DatabaseAccess access)
        {
            InitializeComponent();
            this.access = access;

            DataTable data = access.GetTable("CONSIGNORS");
            ConsignorView.DataSource = data;

        }

        private void buttonAddConsignor_Click(object sender, EventArgs e)
        {
            Consignor consignor = new Consignor();
            consignor.ShowDialog();
        }

        private void textBoxSearchInput_TextChanged(object sender, EventArgs e)
        {

            string str = "'" + textBoxSearchInput.Text + "'";

            DataTable data = access.GetTable("CONSIGNORS " +
                "WHERE CONSIGNOR_ID LIKE" + str +
                "OR NAME LIKE " + str);
            ConsignorView.DataSource = data;

        }
    }
}
