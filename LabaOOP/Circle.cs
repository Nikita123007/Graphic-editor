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
    class Circle : Shape
    {
        private int side;
        public Circle(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen)
        {
        }

        override public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) > 0))
            {
                side = ((FinishX - StartX) + (FinishY - StartY)) / 2;
                g.DrawEllipse(p, StartX, StartY, side, side);
            }
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
            {
                side = ((FinishX - StartX) + (StartY - FinishY)) / 2;
                g.DrawEllipse(p, StartX, StartY - side, side, side);
            }
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
            {
                side = ((StartX - FinishX) + (FinishY - StartY)) / 2;
                g.DrawEllipse(p, StartX - side, StartY, side, side);
            }
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
            {
                side = ((StartX - FinishX) + (StartY - FinishY)) / 2;
                g.DrawEllipse(p, StartX - side, StartY - side, side, side);
            }
        }

        public override bool Selectable(int mouseX, int mouseY)
        {
            double radius = side / 2;
            int centerX = 0;
            int centerY = 0;
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) > 0))
            {
                centerX = StartX + side / 2;
                centerY = StartY + side / 2;
            }
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
            {
                centerX = StartX + side / 2;
                centerY = StartY - side / 2;
            }
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
            {
                centerX = StartX - side / 2;
                centerY = StartY + side / 2;
            }
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
            {
                centerX = StartX - side / 2;
                centerY = StartY - side / 2;
            }
            double distance = Math.Sqrt(Math.Pow(mouseX - centerX, 2) + Math.Pow(mouseY - centerY, 2));
            if (distance <= radius)
                return true;
            else
                return false;
        }
    }
}
