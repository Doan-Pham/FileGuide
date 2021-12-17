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

namespace FileGuide.CustomControls
{
    class GradientPanel : Panel
    {
        public Color FirstColor { get; set; }
        public Color SecondColor { get; set; }
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.FirstColor, this.SecondColor, Angle);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
