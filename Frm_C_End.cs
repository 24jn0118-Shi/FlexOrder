using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_End : Form
    {
        string ordertype;
        public Frm_C_End(string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_C_End_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl1.Text = lblEnd1.Text;
            string filename = "W:\\24JN01卒業制作\\GroupI\\sound\\SoundEnd";
            switch (ordertype) 
            {
                case "in":
                    lblOrderType.Text = lblIn.Text;
                    lbl2.Text = lblEndIn2.Text;
                    filename += "In";
                    break;
                case "out":
                    lblOrderType.Text = lblOut.Text;
                    lbl2.Text = lblEndOut2.Text;
                    filename += "Out";
                    break;
                default:
                    Console.WriteLine("Form Frm_C_End Load Type Error");
                    break;
            }
            filename += "_";
            filename += Thread.CurrentThread.CurrentUICulture.Name;
            filename += ".wav";
            SoundPlayer player = new SoundPlayer(@filename);
            //player.PlaySync();
            Task.Run(() =>{player.PlaySync();});

        }
        private void Frm_C_End_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            if (ordertype == "in" || ordertype == "out") 
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
