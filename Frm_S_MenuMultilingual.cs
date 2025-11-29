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
        string type;
        string goodscode;
        public Frm_S_MenuMultilingual(string type, string goodscode, Form parent)
        {
            InitializeComponent();
            lblTitle.Text = goodscode;
            this.type = type;
            this.goodscode = goodscode;
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

        private void Frm_S_MenuMultilingual_Load(object sender, EventArgs e)
        {

        }
    }
}
