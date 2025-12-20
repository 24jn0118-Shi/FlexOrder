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
        private const string TempCacheFolderName = "Images_tmp";
        private const string LastRunLogFile = "ImageCacheLog.txt";

        private static string CacheDirectory => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CacheFolderName);
        private static string TempCacheDirectory => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TempCacheFolderName);
        private static string LogFilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LastRunLogFile);

        private static string imagepath = Path.Combine(Application.StartupPath, "Images");

        public static void CheckAndCacheAllImages(bool forceexecutecache)
        {
            if (IsCacheUpToDate() && !forceexecutecache)
            {
                Console.WriteLine("Caching skipped");
                return;
            }
            Console.WriteLine("Start safe caching...");
            try
            {
                PrepareTempCache();
                Dictionary<int, byte[]> imageDataMap =
                    GoodsTable.GetImagesFromDatabase();
                if (imageDataMap.Count == 0) 
                {
                    MessageBox.Show("No images downloaded", "Error",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    SaveImagesToFiles(imageDataMap, TempCacheDirectory);
                    ReplaceCacheAtomically();
                    RecordSuccessfulRunDate();
                    Console.WriteLine("Images cached successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caching failed: {ex.Message}");
                CleanupTempCache();
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
        private static void PrepareTempCache()
        {
            if (Directory.Exists(TempCacheDirectory))
            {
                Directory.Delete(TempCacheDirectory, true);
            }
            Directory.CreateDirectory(TempCacheDirectory);
        }
        private static void SaveImagesToFiles(Dictionary<int, byte[]> imageDataMap, string targetDirectory)
        {
            foreach (var kvp in imageDataMap)
            {
                int id = kvp.Key;
                byte[] data = kvp.Value;

                string filePath = Path.Combine(targetDirectory, $"{id}.jpg");

                using (MemoryStream ms = new MemoryStream(data))
                using (Image image = Image.FromStream(ms))
                {
                    image.Save(filePath, ImageFormat.Jpeg);
                }
            }
        }
        private static void ReplaceCacheAtomically()
        {
            if (Directory.Exists(CacheDirectory))
            {
                Directory.Delete(CacheDirectory, true);
            }

            Directory.Move(TempCacheDirectory, CacheDirectory);
        }
        private static void CleanupTempCache()
        {
            if (Directory.Exists(TempCacheDirectory))
            {
                Directory.Delete(TempCacheDirectory, true);
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
        public static Image ResizeImageToCell(Image originalImage, int targetWidth, int targetHeight) 
        {
            int maxDimension = targetHeight;

            float ratioX = (float)maxDimension / originalImage.Width;
            float ratioY = (float)maxDimension / originalImage.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            Bitmap newImage = new Bitmap(targetWidth, targetHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.Clear(Color.White);
                int x = (targetWidth - newWidth) / 2;
                int y = (targetHeight - newHeight) / 2;

                g.DrawImage(originalImage, x, y, newWidth, newHeight);
            }
            return newImage;
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
        /*
        public static void ExportInitialBinary(bool withgoodscode) 
        {
            using (StreamWriter sw = new StreamWriter(WRITEBINARYFILE, false))
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

            }
        }*/
    }
}
