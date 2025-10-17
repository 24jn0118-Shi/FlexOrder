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
    
    public partial class FrmTempStart : Form
    {
        public FrmTempStart()
        {
            InitializeComponent();
            lblWelcome.Text = "FlexOrderアプリケーションの実装時に、\n" +
                "店舗側と顧客側の二つに分かれるため、\n" +
                "本画面は削除されます。\n" +
                "あらかじめご了承ください。\n\n" +
                "Group I Presents\n" +
                "Leader:          Shi Kaiyuan\n" +
                "Design Leader:   Kudriavtsev Sergei\n" +
                "Test Leader:     Tanaka Takahiro\n" +
                "Database Leader: Minami Yuki\n";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCIndex form = new FrmCIndex();
            form.ShowDialog();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            FrmSLogin form = new FrmSLogin();
            form.ShowDialog();
        }
    }
}
