using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder_Prototype
{
    
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt % 4 == 0)
            {
                textBox1.Text = "←←←";
                button1.Text = "→→→";
            }
            else if(cnt % 4 == 1)
            {
                textBox1.Text = "↑↑↑";
                button1.Text = "↓↓↓";
            }
            else if (cnt % 4 == 2)
            {
                textBox1.Text = "→→→";
                button1.Text = "←←←";
            }
            else
            {
                textBox1.Text = "↓↓↓";
                button1.Text = "↑↑↑";
            }
            cnt++;
        }
    }
}
