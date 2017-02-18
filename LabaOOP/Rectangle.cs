using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
    class Rectangle : Shape
    {
        public Rectangle(int StartX, int StartY, int FinishX, int FinishY, Color Color, PictureBox pictureBox) : base(StartX, StartY, FinishX, FinishY, Color, pictureBox)
        {
        }

        override public void Draw()
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color);
            g.DrawRectangle(p, StartX, StartY, FinishX - StartX, FinishY - StartY);
        }
    }
}
