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
        private static string WRITEFILE = @"W:\24JN01卒業制作\GroupI\DBReset\SecurityLog.txt";

        private void WriteSecurityLog(string userid, string obj, string objid, string action, string message) 
        {
            using (StreamWriter sw = new StreamWriter(WRITEFILE, true))
            {
                string line = "";
                line = line + userid + "," + obj + "," + objid + "," + action+ "," + message + "," + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                sw.WriteLine(line);
            }
        }






    }
}
