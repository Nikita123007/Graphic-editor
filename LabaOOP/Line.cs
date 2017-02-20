using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
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
    }
}
