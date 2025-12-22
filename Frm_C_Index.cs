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
            SwitchLanguage("ja");
            InitializeComponent();
        }
        private void btnDinein_Click(object sender, EventArgs e)
        {
            Frm_C_Menu form = new Frm_C_Menu(false, "in");
            form.ShowDialog();
        }
        private void btnTakeout_Click(object sender, EventArgs e)
        {
            Frm_C_Menu form = new Frm_C_Menu(true, "out");
            form.ShowDialog();
        }

        private void FrmCIndex_Load(object sender, EventArgs e)
        {
            ApplyResources(this, Thread.CurrentThread.CurrentUICulture.Name);
            //ImagePro.CheckAndCacheAllImages(true);
            ImagePro.CheckAndCacheAllImages(false);
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
        private void Frm_C_Index_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = Char.ToLower(e.KeyChar);
            if (keyChar == 'u')
            {
                ImagePro.CheckAndCacheAllImages(true);
            }
        }
    }
}
