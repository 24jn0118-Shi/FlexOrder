using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class FrmCIndex : Form
    {
        public FrmCIndex()
        {
            InitializeComponent();
        }

        private void btnDinein_Click(object sender, EventArgs e)
        {
            FrmCMenu form = new FrmCMenu();
            form.ShowDialog();
        }

        private void FrmCIndex_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja");
            ApplyResources(this, Thread.CurrentThread.CurrentUICulture.Name);
        }

        private void ApplyResources(Control control, string cultureName)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmCIndex));

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
    }
}
