using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlexOrder
{
    public class BigCheckBox : CheckBox
    {
        private const int BOX_SIZE = 32;   // Размер квадрата
        private const int PADDING = 5;     // Внутренний отступ от краев

        public BigCheckBox()
        {
            this.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Regular);

            // 1. Включаем AutoSize, чтобы контрол сам сжимался под контент
            this.AutoSize = true;

            // 2. Убираем MinimumSize, который создавал тот самый "пробел"
            this.MinimumSize = new Size(0, 0);

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
        }

        // Переопределяем расчет размера, чтобы убрать лишнее поле справа
        public override Size GetPreferredSize(Size proposedSize)
        {
            // Считаем размер квадрата с отступами
            int width = BOX_SIZE + (PADDING * 2);
            int height = BOX_SIZE + (PADDING * 2);

            // Если текст есть, добавляем его ширину к результату
            if (!string.IsNullOrEmpty(this.Text))
            {
                Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
                width += PADDING + textSize.Width;
                height = Math.Max(height, textSize.Height + (PADDING * 2));
            }

            return new Size(width, height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Очистка фона (используем прозрачность или цвет родителя)
            if (Parent != null)
            {
                using (var brush = new SolidBrush(Parent.BackColor))
                    e.Graphics.FillRectangle(brush, ClientRectangle);
            }
            else
            {
                e.Graphics.Clear(this.BackColor);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Центрируем квадрат по вертикали
            Rectangle boxRect = new Rectangle(
                PADDING,
                (Height - BOX_SIZE) / 2,
                BOX_SIZE,
                BOX_SIZE);

            // Рисуем рамку чекбокса
            using (Pen borderPen = new Pen(Color.Black, 2))
            using (SolidBrush backBrush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(backBrush, boxRect);
                e.Graphics.DrawRectangle(borderPen, boxRect);
            }

            // Рисуем галочку, если Checked == true
            if (Checked)
            {
                using (Pen checkPen = new Pen(Color.FromArgb(40, 120, 220), 4))
                {
                    // Рисуем "птичку" внутри boxRect
                    e.Graphics.DrawLine(checkPen,
                        boxRect.Left + 7, boxRect.Top + BOX_SIZE / 2,
                        boxRect.Left + BOX_SIZE / 2 - 2, boxRect.Bottom - 8);

                    e.Graphics.DrawLine(checkPen,
                        boxRect.Left + BOX_SIZE / 2 - 2, boxRect.Bottom - 8,
                        boxRect.Right - 7, boxRect.Top + 7);
                }
            }

            // Рисуем текст только если он не пустой
            if (!string.IsNullOrEmpty(this.Text))
            {
                using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
                {
                    Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
                    float textY = (Height - textSize.Height) / 2f;
                    e.Graphics.DrawString(this.Text, this.Font, textBrush, boxRect.Right + PADDING, textY);
                }
            }
        }

        // Используем OnCheckedChanged для перерисовки, так как базовый клик сам меняет Checked
        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            this.Invalidate();
        }
    }
}