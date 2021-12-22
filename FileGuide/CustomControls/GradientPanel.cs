using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Reflection;
using Guna.UI2.WinForms;
using System.IO.Compression;
using Plasmoid.Extensions;
namespace FileGuide.CustomControls
{
    class GradientPanel : Panel
    {
        public Color FirstColor { get; set; }
        public Color SecondColor { get; set; }
        public float Angle { get; set; }
        public int BorderRadius { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            Graphics g = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.FirstColor, this.SecondColor, Angle);
            g.FillRoundedRectangle(brush, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height, BorderRadius, RectangleEdgeFilter.All);

            //g.DrawRoundedRectangle(new Pen(Color.Red, 5.0f), ClientRectangle, 20);
            // g.FillRoundedRectangle(new SolidBrush(Color.Red), 10, 10, this.Width - 40, this.Height - 60, 10);
            //e.Graphics.FillRectangle(brush, this.ClientRectangle);
            //e.Graphics.FillRoundedRectangle(brush, ClientRectangle, BorderRadius, RectangleEdgeFilter.All);
            base.OnPaint(e);
        }
    }
}
