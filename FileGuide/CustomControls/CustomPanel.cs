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
    class CustomPanel : Panel
    {
        public Color FirstColor { get; set; }
        public Color SecondColor { get; set; }
        public Color HoverColor { get; set; }
        public float Angle { get; set; }
        public int BorderRadius { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.
            DoubleBuffered = true;
            Graphics g = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.FirstColor, this.SecondColor, Angle);
            g.FillRoundedRectangle(brush, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height, BorderRadius, RectangleEdgeFilter.All);
            base.OnPaint(e);
        }

    }
}
