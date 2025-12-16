using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrder
{
    public class SecurityLogger
    {
        private static string WRITEFILE1 = @"W:\24JN01卒業制作\GroupI\test\SecurityLog.txt";
        private static string WRITEFILE2 = @"W:\24JN01卒業制作\GroupI\test\セキュリティログ.txt";

        public static void WriteSecurityLog(string userid, string obj, string objid, string action, string message) 
        {
            using (StreamWriter sw = new StreamWriter(WRITEFILE1, true))
            {
                string line = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "," + userid + "," + obj + "," + objid + "," + action+ "," + message;
                sw.WriteLine(line);
            }
            using (StreamWriter sw = new StreamWriter(WRITEFILE2, true))
            {
                string line = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " に ユーザー " + userid + " が " + obj + " の " + objid + " を " + action + " した。備考： " + message + "。";
                sw.WriteLine(line);
            }
        }






    }
}
