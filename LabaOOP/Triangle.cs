using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
    class Triangle : Shape
    {
        public Triangle(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen, PictureBox pictureBox) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen, pictureBox)
        {
        }

        override public void Draw()
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            Point[] pointsTriangle = new Point[3];
            pointsTriangle[0] = new Point(StartX, FinishY);
            pointsTriangle[1] = new Point(FinishX, FinishY);
            pointsTriangle[2] = new Point((StartX + FinishX) / 2, StartY);
            g.DrawPolygon(p, pointsTriangle);
        }
    }
}
