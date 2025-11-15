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
    public partial class Frm_S_MenuEdit : Form
    {
        string type;
        public Frm_S_MenuEdit(String type)
        {
            InitializeComponent();
            if (type == "Add")
            {
                lblTitle.Text = "商品追加";
            } else 
            if (type == "Edit") 
            {
                lblTitle.Text = "商品編集";
            }
            this.type = type;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Frm_S_MenuMultilingual frm_S_MenuMultilingual = new Frm_S_MenuMultilingual(type, this);
            frm_S_MenuMultilingual.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
