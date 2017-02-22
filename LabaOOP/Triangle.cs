using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
    [Serializable]
    class Triangle : Shape
    {
        public Triangle(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen)
        {
        }

        override public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            Point[] pointsTriangle = new Point[3];
            pointsTriangle[0] = new Point(StartX, FinishY);
            pointsTriangle[1] = new Point(FinishX, FinishY);
            pointsTriangle[2] = new Point((StartX + FinishX) / 2, StartY);
            g.DrawPolygon(p, pointsTriangle);
        }

        public override bool Selectable(int mouseX, int mouseY)
        {
            double halfWidth = (Math.Abs(StartX - FinishX)) / 2;
            double height = Math.Abs(StartY - FinishY);
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) > 0))
                if ((mouseX > StartX) && (mouseX < FinishX) && (mouseY > StartY) && (mouseY < FinishY))
                    if ((mouseX - StartX) <= (FinishX - mouseX))
                        return ((mouseX - StartX) / (halfWidth) >= ((FinishY - mouseY) / (height)));
                    else
                        return ((FinishX - mouseX) / (halfWidth) >= ((FinishY - mouseY) / (height)));
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
                if ((mouseX > StartX) && (mouseX < FinishX) && (mouseY < StartY) && (mouseY > FinishY))
                    if ((mouseX - StartX) <= (FinishX - mouseX))
                        return ((mouseX - StartX) / (halfWidth) >= ((mouseY - FinishY) / (height)));
                    else
                        return ((FinishX - mouseX) / (halfWidth) >= ((mouseY - FinishY) / (height)));
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
                if ((mouseX < StartX) && (mouseX > FinishX) && (mouseY > StartY) && (mouseY < FinishY))
                    if ((StartX - mouseX) <= (mouseX - FinishX))
                        return ((StartX - mouseX) / (halfWidth) >= ((FinishY - mouseY) / (height)));
                    else
                        return ((mouseX - FinishX) / (halfWidth) >= ((FinishY - mouseY) / (height)));
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
                if ((mouseX < StartX) && (mouseX > FinishX) && (mouseY < StartY) && (mouseY > FinishY))
                    if ((StartX - mouseX) <= (mouseX - FinishX))
                        return ((StartX - mouseX) / (halfWidth) >= ((mouseY - FinishY) / (height)));
                    else
                        return ((mouseX - FinishX) / (halfWidth) >= ((mouseY - FinishY) / (height)));
            return false;
        }
    }
}
