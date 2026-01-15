using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_Menu : Form
    {
        // ==========================================
        // 🌐 言語設定と定数 (Language & Constants)
        // ==========================================
        private readonly Dictionary<string, int> langMap = new Dictionary<string, int>()
        {
            { "ja", 1 }, { "en", 2 }, { "zh", 3 }, { "ru", 4 }
        };

        private int currentLangNo = 1;
        private bool vege = false;
        private string ordertype;

        public Order currentOrder = new Order();

        private string currentGroupCode = "RECOMMEND";
        private RoundButton activeCategoryButton = null;

        private readonly Dictionary<string, List<Goods>> goodsCache
            = new Dictionary<string, List<Goods>>();

        // ==========================================
        // 🏗️ コンストラクタ (Constructors)
        // ==========================================
        public Frm_C_Menu(bool isTakeout, string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            currentOrder.is_takeout = isTakeout;
        }

        public Frm_C_Menu(Order order, string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            currentOrder = order;
        }

        // ==========================================
        // 🚀 フォームイベント (Form Events)
        // ==========================================
        private void FrmCMenu_Load(object sender, EventArgs e)
        {
            ckbVeget.CheckedChanged -= ckbVeget_CheckedChanged;
            ckbVeget.CheckedChanged += ckbVeget_CheckedChanged; 

            // 言語設定の取得
            string lang = Thread.CurrentThread.CurrentUICulture.Name;
            if (langMap.TryGetValue(lang, out int l))
                currentLangNo = l;

            // 初期表示データの構築
            BuildCategoryButtons();
            SelectFirstCategory();
            RefreshCart();
        }

        // ==========================================
        // 📂 カテゴリ制御 (Category Control)
        // ==========================================

        // カテゴリボタンの生成
        private void BuildCategoryButtons()
        {
            flowLayoutPanelCategory.Controls.Clear();
            activeCategoryButton = null;

            // おすすめ商品の確認
            if (HasVisibleGoods("RECOMMEND"))
            {
                flowLayoutPanelCategory.Controls.Add(
                    CreateCategoryButton(GetRecommendText(), "RECOMMEND"));
            }

            // DBからカテゴリ一覧を取得
            GoodsGroupTable table = new GoodsGroupTable();
            var groups = table.GetAllAvailableGroup(currentLangNo);

            foreach (var g in groups)
            {
                // 表示可能な商品があるカテゴリのみ追加
                if (!HasVisibleGoods(g.group_code)) continue;
                flowLayoutPanelCategory.Controls.Add(
                    CreateCategoryButton(g.group_name, g.group_code));
            }
        }

        private RoundButton CreateCategoryButton(string text, string groupCode)
        {
            RoundButton btn = new RoundButton
            {
                Text = text,
                Tag = groupCode,
                Width = 160,
                Height = 70,
                Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                NormalColor = Color.FromArgb(229, 57, 53), // 通常時：赤
                HoverColor = Color.FromArgb(25, 118, 210),
                PressedColor = Color.FromArgb(198, 40, 40)
            };
            btn.Click += CategoryButton_Click;
            return btn;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            if (!(sender is RoundButton btn)) return;
            SetActiveCategory(btn);
            currentGroupCode = btn.Tag.ToString();
            LoadProducts(currentGroupCode);
        }

        // 選択中のカテゴリをハイライト表示
        private void SetActiveCategory(RoundButton btn)
        {
            if (activeCategoryButton != null)
            {
                activeCategoryButton.NormalColor = Color.FromArgb(229, 57, 53); // 赤に戻す
                activeCategoryButton.Invalidate();
            }
            activeCategoryButton = btn;
            btn.NormalColor = Color.FromArgb(25, 118, 210); // 選択時：青
            btn.Invalidate();
        }

        // 最初のカテゴリを自動選択
        private void SelectFirstCategory()
        {
            if (flowLayoutPanelCategory.Controls.Count == 0)
            {
                flowLayoutPanelContent.Controls.Clear();
                return;
            }
            RoundButton first = flowLayoutPanelCategory.Controls[0] as RoundButton;
            if (first != null) CategoryButton_Click(first, EventArgs.Empty);
        }

        // ==========================================
        // 🍱 商品表示 (Product Display)
        // ==========================================
        private void LoadProducts(string groupCode)
        {
            flowLayoutPanelContent.Controls.Clear();

            if (!goodsCache.ContainsKey(groupCode))
            {
                GoodsTable t = new GoodsTable();
                goodsCache[groupCode] =
                    groupCode == "RECOMMEND"
                        ? t.GetRecommendGoods(currentLangNo)
                        : t.GetGoodsByGroup(currentLangNo, groupCode, true);
            }

            foreach (var g in goodsCache[groupCode])
            {
                // ベジタリアンフィルターの適用
                if (vege && !g.is_vegetarian) continue;

                ProductItem item = new ProductItem
                {
                    Id = g.goods_id,
                    ProductTitle = g.goods_name,
                    ProductPrice = "¥ " + g.goods_price.ToString("N0"),
                    Font = new Font("Microsoft YaHei UI", 11)
                };

                string img = ImagePro.GetImagePath(g.goods_image_filename);
                item.ProductImage = File.Exists(img)
                    ? Image.FromFile(img)
                    : Properties.Resources.noimage;

                item.ProductClicked += ProductItem_ProductClicked;
                flowLayoutPanelContent.Controls.Add(item);
            }
        }

        private void ProductItem_ProductClicked(ProductItem item)
        {
            using (Frm_C_GoodsDetail f = new Frm_C_GoodsDetail(item.Id))
            {
                if (f.ShowDialog() == DialogResult.OK && f.AddedItem != null)
                {
                    currentOrder.AddItem(
                        f.AddedItem.goods_id,
                        f.AddedItem.goods_name,
                        f.AddedItem.price,
                        f.AddedItem.quantity);
                    RefreshCart();
                }
            }
        }

        // ==========================================
        // 🌱 ベジタリアン設定 (Vegetarian Toggle)
        // ==========================================
        private void ckbVeget_CheckedChanged(object sender, EventArgs e)
        {
            vege = ckbVeget.Checked;
            string previousGroupCode = currentGroupCode;
            BuildCategoryButtons();
            RoundButton btnToActivate = flowLayoutPanelCategory.Controls
                .OfType<RoundButton>()
                .FirstOrDefault(b => b.Tag.ToString() == previousGroupCode);
            if (btnToActivate != null)
            {
                CategoryButton_Click(btnToActivate, EventArgs.Empty);
            }
            else
            {
                SelectFirstCategory();
            }
        }

        private void lblVeget_Click(object sender, EventArgs e)
        {
            ckbVeget.Checked = !ckbVeget.Checked;
        }

        // ==========================================
        // 🛒 カート管理 (Cart Management)
        // ==========================================
        private void RefreshCart()
        {
            dgvOrderList.SuspendLayout();
            dgvOrderList.Rows.Clear();
            dgvOrderList.Invalidate();

            if (currentOrder.orderdetaillist == null || currentOrder.orderdetaillist.Count == 0)
            {
                txtKaikei.Text = "¥ 0";
                btnConfirm.Enabled = false;
                btnConfirm.NormalColor = Color.FromArgb(189, 189, 189);
                btnConfirm.Invalidate();
                dgvOrderList.ResumeLayout();
                return;
            }

            foreach (var d in currentOrder.orderdetaillist)
            {
                int rowIndex = dgvOrderList.Rows.Add(
                    d.goods_name,
                    "➖",
                    d.quantity,
                    "➕",
                    d.Subtotal.ToString("N0")
                );
                dgvOrderList.Rows[rowIndex].Tag = d.goods_id;

                dgvOrderList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 240);
            }

            txtKaikei.Text = "¥ " + CalculateTotal().ToString("N0");
            btnConfirm.Enabled = true;
            btnConfirm.NormalColor = Color.FromArgb(67, 160, 70);
            dgvOrderList.ClearSelection();
            dgvOrderList.CurrentCell = null;
            dgvOrderList.ResumeLayout();
            dgvOrderList.Update();
            btnConfirm.Invalidate();
        }

        private int CalculateTotal()
        {
            return currentOrder.orderdetaillist.Sum(d => d.Subtotal);
        }

        // ==========================================
        // 🏁 最終アクション (Final Actions)
        // ==========================================

        // 注文確定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            currentOrder.RemoveZeros();
            if (ordertype != "edit")
            {
                using (Frm_C_Cart f = new Frm_C_Cart(ordertype, currentOrder))
                {
                    if (f.ShowDialog() != DialogResult.OK)
                    {
                        currentOrder = f.currentOrder;
                        RefreshCart();
                    }
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        // 最初からやり直し
        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentOrder.orderdetaillist.Clear();
            RefreshCart();
        }

        // 戻るボタン
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        // ==========================================
        // 🔍 ヘルパーメソッド (Helpers)
        // ==========================================

        // 指定したカテゴリに表示可能な商品があるかチェック
        private bool HasVisibleGoods(string groupCode)
        {
            if (!goodsCache.ContainsKey(groupCode))
            {
                GoodsTable t = new GoodsTable();
                goodsCache[groupCode] =
                    groupCode == "RECOMMEND"
                        ? t.GetRecommendGoods(currentLangNo)
                        : t.GetGoodsByGroup(currentLangNo, groupCode, true);
            }
            return goodsCache[groupCode].Any(g => !vege || g.is_vegetarian);
        }

        private string GetRecommendText()
        {
            switch (currentLangNo)
            {
                case 1: return "おすすめ";
                case 2: return "Recommend";
                case 3: return "推荐";
                case 4: return "Рекомендуем";
                default: return "Recommend";
            }
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || !(dgvOrderList.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
            {
                return;
            }

            int minusColumnIndex = 1;
            int plusColumnIndex = 3;
            var itemToModify = currentOrder.orderdetaillist[e.RowIndex];

            if (e.ColumnIndex == plusColumnIndex)
            {

                currentOrder.PlusMinus(itemToModify.goods_id, 1);
            }
            else if (e.ColumnIndex == minusColumnIndex)
            {
                currentOrder.PlusMinus(itemToModify.goods_id, -1);
            }
            RefreshCart();
        }
    }
}