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
    class Ellipse : Shape
    {
        public Ellipse(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen) : base(StartX, StartY, FinishX, FinishY, Color, WidthPen)
        {
        }

        override public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen p = new Pen(Color, WidthPen);
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) > 0))
                g.DrawEllipse(p, StartX, StartY, FinishX - StartX, FinishY - StartY);
            if (((FinishX - StartX) > 0) && ((FinishY - StartY) < 0))
                g.DrawEllipse(p, StartX, FinishY, FinishX - StartX, StartY - FinishY);
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) > 0))
                g.DrawEllipse(p, FinishX, StartY, StartX - FinishX, FinishY - StartY);
            if (((FinishX - StartX) < 0) && ((FinishY - StartY) < 0))
                g.DrawEllipse(p, FinishX, FinishY, StartX - FinishX, StartY - FinishY);
        }

        public override bool Selectable(int mouseX, int mouseY)
        {
            int centerX = (StartX + FinishX) / 2;
            int centerY = (StartY + FinishY) / 2;
            int a = (FinishY - StartY) / 2;
            int b = (FinishX - StartX) / 2;
            double result = Math.Pow(mouseX - centerX, 2) / Math.Pow(b, 2) + Math.Pow(mouseY - centerY, 2) / Math.Pow(a, 2);
            return (result <= 1);
        }
    }
}
