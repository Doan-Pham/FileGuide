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
using System.IO.Compression;

namespace FileGuide
{
    class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (TabCount <= 0) return;
            // Draw tabpage area
            Rectangle tabPageRect = ClientRectangle;
            using (var br = new SolidBrush(FrmMain.PrimaryBackgroundColor))
            {
                e.Graphics.FillRectangle(br, 
                    new Rectangle(tabPageRect.Left, tabPageRect.Y, tabPageRect.Width, tabPageRect.Height ));
            }

            // Draw tab headers
            int imageSize = 16;
            for (int index = 0; index < TabCount; index++)
            {
                tabPageRect = GetTabRect(index);
                DrawTabBackgroundRectangle(e.Graphics, index, tabPageRect);
                DrawTabText(e.Graphics, index, tabPageRect);

                // Draw tab icon (plus sign/close sign)
                if (index == TabCount - 1)
                {
                    Image addImage;
                    if (FrmMain.isInDarkMode)
                        addImage = Properties.Resources.Sign_Plus_DarkMode;
                    else
                        addImage = Properties.Resources.Sign_Plus;
                    e.Graphics.DrawImage
                        (addImage,
                        tabPageRect.Left + (tabPageRect.Width - imageSize) / 2,
                        tabPageRect.Top + (tabPageRect.Height - imageSize) / 2,
                        imageSize,
                        imageSize);
                }
                else
                {
                    Image closeImage;
                    if (FrmMain.isInDarkMode)
                        closeImage = Properties.Resources.Sign_Close_DarkMode;
                    else
                        closeImage = Properties.Resources.Sign_Close;
                    e.Graphics.DrawImage
                        (closeImage,
                        tabPageRect.Right - imageSize - 8,
                        tabPageRect.Top + (tabPageRect.Height - imageSize) / 2,
                        imageSize,
                        imageSize);
                }
            }
        }


        protected void DrawTabBackgroundRectangle(Graphics g, int index, Rectangle tabHeaderRect)
        {
            if (index == 0) tabHeaderRect = new Rectangle(tabHeaderRect.Left - 2, tabHeaderRect.Top, tabHeaderRect.Width + 2, tabHeaderRect.Height);
            if (index != this.SelectedIndex)
                tabHeaderRect = new Rectangle(tabHeaderRect.Left, tabHeaderRect.Top + 2, tabHeaderRect.Width, tabHeaderRect.Height - 2);
            Color tabColor;

            if (index == this.SelectedIndex) tabColor = FrmMain.FocusedSelectColor;
            else tabColor = FrmMain.UnfocusedSelectColor;
            using (var br = new SolidBrush(tabColor))
            {
                g.FillRectangle(br, tabHeaderRect);
            }
            // Draw the separator line on the right side of tab header
            using (var pen = new Pen(Color.FromArgb(186, 186, 186), 2.0f))
            {
                g.DrawLine(pen, tabHeaderRect.Right - 1, tabHeaderRect.Top + 5, tabHeaderRect.Right - 1, tabHeaderRect.Bottom - 7);
            }
        }

        protected void DrawTabText(Graphics g, int index, Rectangle rect)
        {
            TextRenderer.DrawText(g, this.TabPages[index].Text, this.Font,
                rect, FrmMain.PrimaryTextColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

    }
}
