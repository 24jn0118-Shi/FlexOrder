using FlexOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            PayjpHelper.LoadKeys();
            Task.Run(() => ImagePro.CheckAndCacheAllImages(true));
            //ImagePro.CheckAndCacheAllImages(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_T_TempStart());
        }
    }
}
