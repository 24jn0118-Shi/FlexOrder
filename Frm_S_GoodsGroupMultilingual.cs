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
    public partial class Frm_S_GoodsGroupMultilingual : Form
    {
        String code;
        public Frm_S_GoodsGroupMultilingual(String code)
        {
            InitializeComponent();
            this.code = code;
        }

    }
}
