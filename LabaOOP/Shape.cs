﻿using System;
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

        public int StartX {get; set;}
        public int StartY { get; set; }
        public int FinishX { get; set; }
        public int FinishY { get; set; }
        public int WidthPen { get; set; }
        public Color Color { get; set; }

        public Shape(int StartX, int StartY, int FinishX, int FinishY, Color Color, int WidthPen, PictureBox pictureBox)
        {
            this.StartX = StartX;
            this.StartY = StartY;
            this.FinishX = FinishX;
            this.FinishY = FinishY;
            this.WidthPen = WidthPen;
            this.Color = Color;
            this.pictureBox = pictureBox;
        }

        abstract public void Draw();
    }
}
