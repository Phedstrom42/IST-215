using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Drawing_Panel
{
    public partial class DrawingPanel : Form
    {
        private Color PaintColor { get; set; }
        private int BrushSize { get; set; }
        private bool ShouldPaint { get; set; }

        public DrawingPanel()
        {
            InitializeComponent();
            ShouldPaint = false;
            BrushSize = 8;
            PaintColor = Color.Black;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                Graphics graphic = panelCanvas.CreateGraphics();

                graphic.FillEllipse(new SolidBrush(PaintColor), e.X, e.Y, BrushSize, BrushSize);
               
            }
        }

        private void paintColor_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(rdColorRed))
            {
                PaintColor = Color.Red;
            }
            else if (sender.Equals(rbColorBlue))
            {
                PaintColor = Color.Blue;
            }
            else if (sender.Equals(rbColorGreen))
            {
                PaintColor = Color.Green;
            }
            else if (sender.Equals(rbColorBlack))
            {
                PaintColor = Color.Black;
            }
        }

        private void brushSize_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(rbSizeSmall))
            {
                BrushSize = 4;
            }
            else if (sender.Equals(rbSizeMedium))
            {
                BrushSize = 8;
            }
            else if (sender.Equals(rbSizeLarge))
            {
                BrushSize = 12;
            }
        }
    }
}
