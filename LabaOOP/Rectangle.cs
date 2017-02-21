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
    class Rectangle : Shape
    {
        public Rectangle(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen)
        {
        }

        override public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            if (((FinishX - StartX)>0) && ((FinishY - StartY)>0))
                g.DrawRectangle(p, StartX, StartY, FinishX - StartX, FinishY - StartY);
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
                g.DrawRectangle(p, StartX, FinishY, FinishX - StartX, StartY - FinishY);
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
                g.DrawRectangle(p, FinishX, StartY, StartX - FinishX, FinishY - StartY);
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
                g.DrawRectangle(p, FinishX, FinishY, StartX - FinishX, StartY - FinishY);
        }
    }
}
