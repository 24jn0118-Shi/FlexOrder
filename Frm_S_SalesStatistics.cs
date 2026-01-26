using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using FlexOrderLibrary;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LicenseContext = OfficeOpenXml.LicenseContext;


namespace FlexOrder
{
    public partial class Frm_S_SalesStatistics : Form
    {
        public Frm_S_SalesStatistics()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_SalesStatistics_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddMonths(-3);
            dtpEnd.Value = DateTime.Today;
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            List<GoodsGroup> groupList = goodsGroupTable.GetGroupByLanguage(1);
            cmbGroup.Items.Add("分類指定なし");
            foreach (GoodsGroup group in groupList)
            {
                cmbGroup.Items.Add(group.group_name);
            }
            cmbGroup.SelectedIndex = 0;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Goods> goodsList;
            GoodsTable goodsTable = new GoodsTable();
            if (cmbGroup.SelectedIndex > 0) 
            {
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                
                GoodsGroup selectedGroup = goodsGroupTable.GetGroupBySort(1, cmbGroup.SelectedIndex);
                goodsList = goodsTable.GetGoodsByGroup(1, selectedGroup.group_code, false);
            }
            else 
            {
                goodsList = goodsTable.GetAllGoodsList(1);
            }
            cmbGoods.Items.Clear();
            cmbGoods.Items.Add("商品指定なし");
            foreach (Goods good in goodsList)
            {
                cmbGoods.Items.Add(good.goods_name);
            }
            cmbGoods.SelectedIndex = 0;

        }

        private void cmbGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex > 0 || cmbGoods.SelectedIndex > 0) 
            { 
                ShowGraph();
            }
        }
        private void ShowGraph() 
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                DateTime tmp = dtpStart.Value;
                dtpStart.Value = dtpEnd.Value;
                dtpEnd.Value = tmp;
            }

            if (cmbGroup.SelectedIndex > 0 && cmbGoods.SelectedIndex == 0)
            {
                Order order = new Order();
                DataTable table = order.GetSalesReportByGroupName(dtpStart.Value, dtpEnd.Value, cmbGroup.Text);

                if (table.Rows.Count > 0)
                {
                    chart1.ChartAreas.Clear();
                    chart1.Series.Clear();
                    chart1.Legends.Clear();

                    //グラフエリアと凡例を作成

                    ChartArea ca = new ChartArea("chartArea");
                    chart1.ChartAreas.Add(ca);//グラフエリア
                    chart1.ChartAreas["chartArea"].AxisX.LabelStyle.Angle = -30;

                    //データ系列を作成
                    System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in table.Rows)
                    {
                        series.Points.AddXY(row["料理名"].ToString(), int.Parse(row["合計金額"].ToString()));
                    }
                    //データ系列をChartコントロールに追加
                    chart1.Series.Add(series);
                }
                else
                {
                    MessageBox.Show("指定された範囲にデータはありません", "データなし",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbGoods.SelectedIndex > 0)
            {
                Order order = new Order();
                DataTable table = order.GetSalesReportByGoodsName(dtpStart.Value, dtpEnd.Value, cmbGoods.Text);

                if (table.Rows.Count > 0)
                {
                    chart1.ChartAreas.Clear();
                    chart1.Series.Clear();
                    chart1.Legends.Clear();

                    //グラフエリアと凡例を作成
                    ChartArea ca = new ChartArea("chartArea");
                    chart1.ChartAreas.Add(ca);//グラフエリア

                    //データ系列を作成
                    System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                    series.ChartType = SeriesChartType.Column;
                    series.XValueType = ChartValueType.DateTime;

                    TimeSpan span = dtpEnd.Value - dtpStart.Value;
                    string format;
                    if (span.Days < 60)
                    {
                        format = "MM/dd";
                    }
                    else
                    {
                        chart1.ChartAreas["chartArea"].AxisX.LabelStyle.Angle = -30;
                        format = "yyyy/MM/dd";
                    }

                    //X軸の目盛の書式設定
                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = format;

                    foreach (DataRow row in table.Rows)
                    {
                        
                        series.Points.AddXY(DateTime.Parse(row["日時"].ToString()), int.Parse(row["合計金額"].ToString()));
                        
                    }
                    //データ系列をChartコントロールに追加
                    chart1.Series.Add(series);
                }
                else
                {
                    MessageBox.Show("指定された範囲にデータはありません", "データなし",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("GroupName かGoodsNameの片方を選択してください", "表示失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            ShowGraph();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                DateTime tmp = dtpStart.Value;
                dtpStart.Value = dtpEnd.Value;
                dtpEnd.Value = tmp;
            }

            if (cmbGroup.SelectedIndex > 0 && cmbGoods.SelectedIndex == 0)
            {

                Order order = new Order();
                DataTable table = order.GetSalesReportByGroupName(dtpStart.Value, dtpEnd.Value, cmbGroup.Text);

                if (table.Rows.Count > 0)
                {
                    ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");

                    string filePath = $"W:\\24JN01卒業制作\\GroupI\\xlsx\\{cmbGroup.Text} {dtpStart.Value:yyyy年MM月dd日}-{dtpEnd.Value:yyyy年MM月dd日}.xlsx";
                    FileInfo fileInfo = new FileInfo(filePath);

                    if (fileInfo.Exists)
                    {
                        fileInfo.Delete();
                        fileInfo = new FileInfo(filePath);
                    }

                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        // ワークシートを追加
                        var ws = package.Workbook.Worksheets.Add("Sheet1");


                        ws.Cells["B2"].Value = $"{cmbGroup.Text} 売上表";
                        ws.Cells["C2"].Value = $"{dtpStart.Value:yyyy年MM月dd日}-{dtpEnd.Value:yyyy年MM月dd日}";

                        //データテーブルからエクセルファイルに書き込み処理
                        ws.Cells[3, 2].LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Medium6);

                        //カラムの幅を自動調整
                        ws.Cells.AutoFitColumns(1);

                        var chart = ws.Drawings.AddChart("棒グラフ", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);
                        chart.Title.Text = "売上数";
                        chart.SetPosition(5, 0, 4, 0); // 行・列の位置
                        chart.SetSize(600, 400);

                        int r = table.Rows.Count;
                        var series = chart.Series.Add($"C3:C{r + 3}", $"B3:B{r + 3}");
                        series.Header = "数量";

                        // ファイルを保存
                        package.Save();

                        MessageBox.Show($"{cmbGroup.Text} {dtpStart.Value:yyyy年MM月dd日}-{dtpEnd.Value:yyyy年MM月dd日}.xlsx に出力されました", "出力成功",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("指定された範囲にデータはありません", "データなし",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbGoods.SelectedIndex > 0) {
                Order order = new Order();
                DataTable table = order.GetSalesReportByGoodsName(dtpStart.Value, dtpEnd.Value, cmbGoods.Text);

                if (table.Rows.Count > 0)
                {
                    try {
                        ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");

                        string filePath = $"W:\\24JN01卒業制作\\GroupI\\xlsx\\{cmbGoods.Text} {dtpStart.Value:yyyy年MM月dd日}-{dtpEnd.Value:yyyy年MM月dd日}.xlsx";
                        FileInfo fileInfo = new FileInfo(filePath);

                        if (fileInfo.Exists)
                        {

                            fileInfo.Delete();
                            fileInfo = new FileInfo(filePath);

                        }
                        
                

                        using (ExcelPackage package = new ExcelPackage(fileInfo))
                        {
                            // ワークシートを追加
                            var ws = package.Workbook.Worksheets.Add("Sheet1");


                            ws.Cells["B2"].Value = $"{cmbGoods.Text} 売上表";
                            ws.Cells["C2"].Value = $"{dtpStart.Value:yyyy年MM月dd日}-{dtpEnd.Value:yyyy年MM月dd日}";



                            //データテーブルからエクセルファイルに書き込み処理
                            ws.Cells[3, 2].LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Medium6);

                            //カラムの幅を自動調整
                            ws.Cells.AutoFitColumns(1);

                            var chart = ws.Drawings.AddChart("棒グラフ", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);
                            chart.Title.Text = "売上数";
                            chart.SetPosition(5, 0, 4, 0); // 行・列の位置
                            chart.SetSize(600, 400);

                            int r = table.Rows.Count;
                            var series = chart.Series.Add($"C3:C{r + 3}", $"B3:B{r + 3}");
                            series.Header = "数量";

                            // ファイルを保存
                            package.Save();

                            MessageBox.Show($"{cmbGoods.Text} {dtpStart.Value:yyyy年MM月dd日}-{dtpEnd.Value:yyyy年MM月dd日}.xlsx に出力されました", "出力成功",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show($"現在開いているexcelファイルを閉じてください", "更新失敗",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error: "+ex.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("指定された範囲にデータはありません", "データなし",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show( "GroupName かGoodsNameの片方を選択してください", "表示失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        
    }
}
