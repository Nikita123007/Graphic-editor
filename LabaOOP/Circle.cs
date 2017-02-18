using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
    class Circle : Shape
    {
        public Circle(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen, PictureBox pictureBox) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen, pictureBox)
        {
        }

        override public void Draw()
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            int side = ((FinishX - StartX) + (FinishY - StartY)) / 2;
            g.DrawEllipse(p, StartX, StartY, side, side);
        }
    }
}
