using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Syroot.Windows.IO;
using Guna.UI2.WinForms;
using System.IO.Compression;

namespace FileGuide
{
    class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            // Take over the painting completely, we want transparency and double-buffering
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = this.ResizeRedraw = true;
        }

        public override Color BackColor
        {
            get { return Color.Transparent; }
            set { base.BackColor = Color.Transparent; }
        }

        protected virtual void DrawTabBackgroundRectangle(Graphics g, int index, Rectangle r)
        {
            if (index == 0) r = new Rectangle(r.Left - 2, r.Top, r.Width + 2, r.Height);
            if (index != this.SelectedIndex) r = new Rectangle(r.Left, r.Top + 2, r.Width, r.Height - 2);
            Color tabColor;

            if (index == this.SelectedIndex) tabColor = FrmMain.SecondaryBackgroundColor;
            else tabColor =  FrmMain.UnfocusedSelectColor;
            using (var br = new SolidBrush(tabColor))
            {
                g.FillRectangle(br, r);
            }
            using (var pen = new Pen(Color.FromArgb(186, 186, 186), 2.0f))
            {
                g.DrawLine(pen, r.Right-1, r.Top+5, r.Right -1, r.Bottom-7);
            } 
        }

        protected virtual void DrawTabText(Graphics g, int index, Rectangle r)
        {
            r.Inflate(-1, -1);
            TextRenderer.DrawText(g, this.TabPages[index].Text, this.Font,
                r, FrmMain.PrimaryTextColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (TabCount <= 0) return;
            // Draw tabpage area
            Rectangle r = ClientRectangle;
            var top = this.GetTabRect(0).Bottom;
            using (var br = new SolidBrush(FrmMain.PrimaryBackgroundColor))
            {
                e.Graphics.FillRectangle(br, new Rectangle(r.Left, top, r.Width, r.Height - top));
            }

            int imageSize = 16;
            // Draw tabs
            for (int index = 0; index < TabCount; index++)
            {
                r = GetTabRect(index);
                DrawTabBackgroundRectangle(e.Graphics, index, r);
                DrawTabText(e.Graphics, index, r);
                if (index == this.SelectedIndex)
                {
                    r.Inflate(-1, -1);
                    ControlPaint.DrawFocusRectangle(e.Graphics, r);
                }

                if (index == TabCount - 1)
                {
                    Image addImage = Properties.Resources.Sign_Plus;
                    e.Graphics.DrawImage
                        (addImage,
                        r.Left + (r.Width - imageSize) / 2,
                        r.Top + (r.Height - imageSize) / 2,
                        imageSize,
                        imageSize);
                }
                else
                {
                    Image closeImage = Properties.Resources.Sign_Close;
                    e.Graphics.DrawImage
                        (closeImage,
                        r.Right - imageSize - 8,
                        r.Top + (r.Height - imageSize) / 2,
                        imageSize,
                        imageSize);
                }
            }
        }
    }
}
