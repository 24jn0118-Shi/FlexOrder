using FlexOrderLibrary;
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
    
    public partial class Frm_T_TempStart : Form
    {
        public Frm_T_TempStart()
        {
            InitializeComponent();
            lblWelcome.Text = "FlexOrderアプリケーションの実装時に、\n" +
                "店舗側と顧客側の二つに分かれるため、\n" +
                "本画面は削除されます。\n" +
                "あらかじめご了承ください";
            lblPresent.Text = "Group I Presents\n" +
                "Leader:          Shi Kaiyuan\n" +
                "Design Leader:   Kudriavtsev Sergei\n" +
                "Test Leader:     Tanaka Takahiro\n" +
                "Database Leader: Minami Yuki";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Frm_C_Index form = new Frm_C_Index();
            form.ShowDialog();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Frm_S_Login form = new Frm_S_Login();
            form.ShowDialog();
        }
        private void btnUpdateImages_Click(object sender, EventArgs e)
        {
            string filepath;
            DialogResult ret = ofdInsertImages.ShowDialog();
            if (ret == DialogResult.OK)
            {
                filepath = ofdInsertImages.FileName;
                Console.WriteLine("From: " + filepath);
                ImagePro imagePro = new ImagePro();

                if (filepath != null)
                {
                    DialogResult dret = MessageBox.Show(filepath + "\nをUpdateしますか", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dret == DialogResult.Yes)
                    {
                        GoodsTable goodsTable = new GoodsTable();
                        int cnt = goodsTable.UpdateImagesFromBinaryFile(filepath);
                        MessageBox.Show(cnt + "件Updateしました", "Update完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
