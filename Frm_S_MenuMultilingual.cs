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
    public partial class Frm_S_MenuMultilingual : Form
    {
        Form parent;
        public Frm_S_MenuMultilingual(string type, Form parent)
        {
            InitializeComponent();
            if (type == "Add")
            {
                lblTitle.Text = "商品追加";
            }
            else
            if (type == "Edit")
            {
                lblTitle.Text = "商品編集";
            }
            this.parent = parent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Frm_S_MenuEditも一緒に閉じる
            parent.Close();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
