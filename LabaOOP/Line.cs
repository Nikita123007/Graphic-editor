using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
    class Line : Shape, IShape
    {
        public Line(int StartX, int StartY, int FinishX, int FinishY, Color Color, PictureBox pictureBox) : base(StartX, StartY, FinishX, FinishY, Color, pictureBox)
        {
        }

        public void Draw()
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color);
            g.DrawLine(p, StartX, StartY, FinishX, FinishY);
        }
    }
}
