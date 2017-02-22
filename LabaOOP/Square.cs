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
    class Square : Shape
    {
        int side;
        public Square(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen)
        {
        }

        override public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) > 0))
            {
                side = ((FinishX - StartX) + (FinishY - StartY)) / 2;
                g.DrawRectangle(p, StartX, StartY, side, side);
            }
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
            {
                side = ((FinishX - StartX) + (StartY - FinishY)) / 2;
                g.DrawRectangle(p, StartX, StartY - side, side, side);
            }
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
            {
                side = ((StartX - FinishX) + (FinishY - StartY)) / 2;
                g.DrawRectangle(p, StartX - side, StartY, side, side);
            }
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
            {
                side = ((StartX - FinishX) + (StartY - FinishY)) / 2;
                g.DrawRectangle(p, StartX - side, StartY - side, side, side);
            }
        }

        public override bool Selectable(int mouseX, int mouseY)
        {
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) > 0))
                return (((mouseX - StartX) < side) && ((mouseX - StartX) > 0) && ((mouseY - StartY) < side) && ((mouseY - StartY) > 0));
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
                return (((mouseX - StartX) < side) && ((mouseX - StartX) > 0) && ((StartY - mouseY) < side) && ((StartY - mouseY) > 0));
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
                return (((StartX - mouseX) < side) && ((StartX - mouseX) > 0) && ((mouseY - StartY) < side) && ((mouseY - StartY) > 0));
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
                return (((StartX - mouseX) < side) && ((StartX - mouseX) > 0) && ((StartY - mouseY) < side) && ((StartY - mouseY) > 0));
            return false;
        }
    }
}
