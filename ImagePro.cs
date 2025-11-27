using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FlexOrder
{
    public class ImagePro
    {
        public static string WRITEBINARYFILE = @"C:\Users\brown\Downloads\Binary.txt";
        string relativePath = Path.Combine(Application.StartupPath, "Images");
        string absolutePath = @"\\192.168.3.3\SharedFolder\Images";

        string imagepath = Path.Combine(Application.StartupPath, "Images");
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
        /*public string CopyImageFile(string sourceFilePath) 
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
        }*/
        public static Image ConvertByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
            {
                return null;
            }
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"失敗: {ex.Message}");
                return null;
            }
        }
        public static void ExportInitialBinary(bool withgoodscode) 
        {
            /*using (StreamWriter sw = new StreamWriter(WRITEBINARYFILE, false))
            {
                GoodsTable goodsTable = new GoodsTable();
                List<Goods> goodslist = goodsTable.GetAllGoodsList(1);
                foreach (Goods good in goodslist)
                {
                    ImagePro imagePro = new ImagePro();
                    String image = imagePro.GetImagePath(good.goods_image);

                    byte[] imageBytes = File.ReadAllBytes(image);
                    string base64String = Convert.ToBase64String(imageBytes);
                    if (withgoodscode) 
                    {
                        base64String = good.goods_code + "," + base64String;
                    }
                    sw.WriteLine(base64String);
                    Console.WriteLine(good.goods_code + "done");
                }

            }*/
        }
    }
}
