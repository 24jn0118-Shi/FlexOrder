using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public class ImagePro
    {
        public static string WRITEBINARYFILE = @"C:\Users\brown\Downloads\Binary.txt";
        string relativePath = Path.Combine(Application.StartupPath, "Images");
        //string absolutePath = @"\\192.168.3.3\SharedFolder\Images";

        private const string CacheFolderName = "Images";
        private const string LastRunLogFile = "ImageCacheLog.txt";

        private static string CacheDirectory => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CacheFolderName);
        private static string LogFilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LastRunLogFile);

        private static string imagepath = Path.Combine(Application.StartupPath, "Images");

        public static void CheckAndCacheAllImages(bool forceexecutecache)
        {
            if (IsCacheUpToDate() && !forceexecutecache)
            {
                Console.WriteLine("Caching skipped because the image was cached within the past hour");
                return;
            }
            Console.WriteLine("Start caching...");
            try
            {
                CleanupCache();
                Dictionary<int, byte[]> imageDataMap = GoodsTable.GetImagesFromDatabase();
                SaveImagesToFiles(imageDataMap);
                RecordSuccessfulRunDate();
                Console.WriteLine("Images cached!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failure: {ex.Message}");
            }
        }
        private static bool IsCacheUpToDate()
        {
            TimeSpan cacheDuration = TimeSpan.FromHours(1);
            if (!File.Exists(LogFilePath))
            {
                return false;
            }
            try
            {
                string lastRunString = File.ReadAllText(LogFilePath).Trim();
                if (DateTime.TryParse(lastRunString, out DateTime lastRunTime))
                {
                    TimeSpan timeSinceLastRun = DateTime.Now - lastRunTime;
                    if (timeSinceLastRun <= cacheDuration)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to read log: {ex.Message}");
            }
            return false;
        }
        private static void RecordSuccessfulRunDate()
        {
            try
            {
                string nowString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                File.WriteAllText(LogFilePath, nowString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log: {ex.Message}");
            }
        }
        private static void CleanupCache()
        {
            if (Directory.Exists(CacheDirectory))
            {
                Directory.Delete(CacheDirectory, true);
            }
            Directory.CreateDirectory(CacheDirectory);
        }
        private static void SaveImagesToFiles(Dictionary<int, byte[]> imageDataMap)
        {
            foreach (var kvp in imageDataMap)
            {
                int id = kvp.Key;
                byte[] data = kvp.Value;
                try
                {
                    string filePath = Path.Combine(CacheDirectory, $"{id}.jpg");
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        using (Image image = Image.FromStream(ms))
                        {
                            image.Save(filePath, ImageFormat.Jpeg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to load Goods: {id} Message: {ex.Message}");
                }
            }
        }
        public static string GetImagePath(string goods_image)
        {
            string path = Path.Combine(CacheDirectory, goods_image);
            if (File.Exists(path))
            {
                return path;
            }
            return null;
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
