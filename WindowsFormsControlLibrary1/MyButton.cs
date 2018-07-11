using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public class MyButton:Control
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);

            LinearGradientBrush brush1 = new LinearGradientBrush(pt1,pt2,FillColor1,FillColor2);

            //圖片品質 設定反鋸齒
            g.SmoothingMode = SmoothingMode.AntiAlias;

            switch(this.FillShape)
            {
                case Shape.Ellipse:
                    g.FillEllipse(brush1, this.ClientRectangle);
                    break;
                case Shape.Rectangle:
                    g.FillRectangle(brush1, this.ClientRectangle);
                    break;
            }
            //Draw String

            float x, y;
            x = (this.ClientRectangle.Width - g.MeasureString(base.Text, base.Font).Width) / 2;
            y = (this.ClientRectangle.Height - g.MeasureString(base.Text, base.Font).Height) / 2;
            g.DrawString(base.Text, base.Font, Brushes.Black, x, y);


        }
        private Color m_FillColor;
        public Color FillColor1
        {
            get
            {
                //........
                return m_FillColor;
            }
            set
            {
                //.......
                m_FillColor = value;
                this.Invalidate();
            }
        }

        public Color FillColor2 { get; set; }

        public enum Shape { Ellipse, Rectangle }
        public Shape FillShape { get; set; }


    }
}
