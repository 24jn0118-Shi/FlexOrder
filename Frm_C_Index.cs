using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_Index : Form
    {
        public Frm_C_Index()
        {
            InitializeComponent();
        }

        private void btnDinein_Click(object sender, EventArgs e)
        {
            Frm_C_Menu form = new Frm_C_Menu("in");
            form.ShowDialog();
        }
        private void btnTakeout_Click(object sender, EventArgs e)
        {
            Frm_C_Menu form = new Frm_C_Menu("out");
            form.ShowDialog();
        }

        private void FrmCIndex_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja");
            ApplyResources(this, Thread.CurrentThread.CurrentUICulture.Name);
        }

        private void ApplyResources(Control control, string cultureName)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(typeof(Frm_C_Index));

            foreach (System.ComponentModel.PropertyDescriptor pd in System.ComponentModel.TypeDescriptor.GetProperties(control))
            {
                if (pd.IsBrowsable && pd.CanResetValue(control) && pd.PropertyType == typeof(string))
                {
                    string resourceName = control.Name + "." + pd.Name;
                    string resourceValue = rm.GetString(resourceName, new CultureInfo(cultureName));

                    if (!string.IsNullOrEmpty(resourceValue))
                    {
                        pd.SetValue(control, resourceValue);
                    }
                }
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyResources(childControl, cultureName);
            }
        }

        private void SwitchLanguage(string cultureName)
        {
            if (string.IsNullOrEmpty(cultureName))
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);
            }

            ApplyResources(this, Thread.CurrentThread.CurrentUICulture.Name);
        }

        private void btnJapanese_Click(object sender, EventArgs e)
        {
            SwitchLanguage("ja");
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            SwitchLanguage("en");
        }

        private void btnChinese_Click(object sender, EventArgs e)
        {
            SwitchLanguage("zh");
        }

        private void btnRussian_Click(object sender, EventArgs e)
        {
            SwitchLanguage("ru");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string WRITEFILE = @"Z:\Binary.txt";
            using (StreamWriter sw = new StreamWriter(WRITEFILE, true))
            {
                GoodsTable goodsTable = new GoodsTable();
                List<Goods> goodslist = goodsTable.GetAllGoodsList(1);
                foreach (Goods good in goodslist)
                {
                    ImagePro imagePro = new ImagePro();
                    String image = imagePro.GetImagePath(good.goods_image);

                    byte[] imageBytes = File.ReadAllBytes(image);
                    string base64String = Convert.ToBase64String(imageBytes);
                    //string line = good.goods_code + "," + base64String;
                    sw.WriteLine(base64String);
                    Console.WriteLine(good.goods_code + "done");
                }
                
            }
        }
    }
}
