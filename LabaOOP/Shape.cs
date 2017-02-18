using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
    abstract class Shape : IShape
    {
        protected PictureBox pictureBox;
        protected int startX;
        protected int startY;
        protected int finishX;
        protected int finishY;
        protected Color color;

        protected int StartX
        {
            get
            {
                return startX;
            }

            set
            {
                startX = value;
            }
        }
        protected int StartY
        {
            get
            {
                return startY;
            }

            set
            {
                startY = value;
            }
        }
        protected int FinishX
        {
            get
            {
                return finishX;
            }

            set
            {
                finishX = value;
            }
        }
        protected int FinishY
        {
            get
            {
                return finishY;
            }

            set
            {
                finishY = value;
            }
        }
        protected Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Shape(int StartX, int StartY, int FinishX, int FinishY, Color Color, PictureBox pictureBox)
        {
            this.StartX = StartX;
            this.StartY = StartY;
            this.FinishX = FinishX;
            this.FinishY = FinishY;
            this.Color = Color;
            this.pictureBox = pictureBox;
        }

        abstract public void Draw();
    }
}
