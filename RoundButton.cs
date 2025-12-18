using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FlexOrder
{
    public class RoundButton : Button
    {
        private bool isPressed = false;
        private bool isHover = false;

        public int CornerRadius { get; set; } = 14;

        public Color NormalColor { get; set; } = Color.FromArgb(55, 55, 55);
        public Color HoverColor { get; set; } = Color.FromArgb(65, 65, 65);
        public Color PressedColor { get; set; } = Color.FromArgb(35, 35, 35);
        public Color BorderColor { get; set; } = Color.Transparent;

        public RoundButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            TabStop = false;

            BackColor = Color.Transparent;
            ForeColor = Color.White;

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.Selectable, false
            );
        }

        // 🔒 Полностью отключаем focus rectangle
        protected override bool ShowFocusCues => false;

        protected override void OnMouseEnter(EventArgs e)
        {
            isHover = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            isHover = false;
            isPressed = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPressed = true;
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isPressed = false;
            Invalidate();
            base.OnMouseUp(e);
        }

        private GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddLine(rect.X + r, rect.Y, rect.Right - r, rect.Y);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddLine(rect.Right, rect.Y + r, rect.Right, rect.Bottom - r);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddLine(rect.Right - r, rect.Bottom, rect.X + r, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.AddLine(rect.X, rect.Bottom - r, rect.X, rect.Y + r);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            float offset = isPressed ? 1.5f : 0f;
            RectangleF rect = new RectangleF(
                offset,
                offset,
                Width - 1.5f - offset,
                Height - 1.5f - offset
            );

            using (GraphicsPath path = GetRoundPath(rect, CornerRadius))
            {
                Region = new Region(path);

                Color fill =
                    isPressed ? PressedColor :
                    isHover ? HoverColor :
                    NormalColor;

                using (SolidBrush brush = new SolidBrush(fill))
                    e.Graphics.FillPath(brush, path);

                if (BorderColor.A > 0)
                {
                    using (Pen pen = new Pen(BorderColor, isPressed ? 1f : 1.5f))
                        e.Graphics.DrawPath(pen, path);
                }
            }

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                Rectangle.Round(rect),
                ForeColor,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter
            );
        }
    }
}