﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStoreApp
{
    public partial class PointOfSale : UserControl
    {
        public PointOfSale()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.ShowDialog();
        }
    }
}
