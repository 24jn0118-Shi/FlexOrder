using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public class ImagePro
    {
        
        string relativePath = Path.Combine(Application.StartupPath, "Images");
        string absolutePath = @"\\192.168.3.3\SharedFolder\Images";

        string imagepath = @"\\192.168.3.3\SharedFolder\Images";
        public string GetImagePath(string filename)
        {
            string path = Path.Combine(imagepath, filename);

            return path;
        }

        public bool DeleteImageFile(List<string> namelist)
        {
            bool allSucceeded = true;
            foreach (string filename in namelist)
            {
                string filepath = GetImagePath(filename);
                if (File.Exists(filepath))
                {
                    try
                    {
                        File.Delete(filepath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"ファイル削除失败: {ex.Message}", "削除失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        allSucceeded = false;
                    }
                }
                else
                {
                    Console.WriteLine($"ファイル {filename}が存在しません", "Message");
                    return true;
                }
            }
            return allSucceeded;
            
        }
        public string CopyImageFile(string sourceFilePath) 
        {
            string newDestinationFilePath;
            if (string.IsNullOrEmpty(sourceFilePath) || !File.Exists(sourceFilePath))
            {
                MessageBox.Show("ファイルパスが存在しません", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            string newResourceName = Path.GetFileName(sourceFilePath);
            newDestinationFilePath = GetImagePath(newResourceName);
            try
            {
                if (!Directory.Exists(imagepath))
                {
                    Directory.CreateDirectory(imagepath);
                }

                File.Copy(sourceFilePath, newDestinationFilePath, true);

                return newDestinationFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ファイル保存失敗: {ex.Message}", "保存失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
