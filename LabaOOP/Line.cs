using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using ShapeLibrary;

namespace LabaOOP
{
    [Serializable]
    class Line : Shape
    {
        public Line(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen)
        {
        }

        override public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            g.DrawLine(p, StartX, StartY, FinishX, FinishY);
        }

        public override bool Selectable(int mouseX, int mouseY)
        {
            double B = 1;
            double A = 0;
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) > 0))
                if ((mouseX > StartX) && (mouseX < FinishX) && (mouseY > StartY) && (mouseY < FinishY))
                    A = ((double)(FinishY - StartY) / (double)(FinishX - StartX));
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
                if ((mouseX > StartX) && (mouseX < FinishX) && (mouseY < StartY) && (mouseY > FinishY))
                    A = -((double)(StartY - FinishY) / (double)(FinishX - StartX));
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
                if ((mouseX < StartX) && (mouseX > FinishX) && (mouseY > StartY) && (mouseY < FinishY))
                    A = -((double)(FinishY - StartY) / (double)(StartX - FinishX));
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
                if ((mouseX < StartX) && (mouseX > FinishX) && (mouseY < StartY) && (mouseY > FinishY))
                    A = ((double)(StartY - FinishY) / (double)(StartX - FinishX));
            mouseY = -mouseY;
            double r = Math.Abs(A * mouseX + B * mouseY - A * StartX + B * StartY) / (Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
            return (r < 5);
        }
    }
}
