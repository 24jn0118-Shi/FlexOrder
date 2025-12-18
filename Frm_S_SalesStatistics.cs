using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_S_SalesStatistics : Form
    {
        public Frm_S_SalesStatistics()
        {
            InitializeComponent();
            label1.Text = "In Development\n開発中";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
