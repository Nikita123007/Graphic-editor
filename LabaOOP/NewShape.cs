using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;
using System.Drawing;
using System.Windows.Forms;

namespace LabaOOP
{
    [Serializable]
    public class NewShape : Shape
    {
        int FinishXOld;
        int FinishYOld;
        private int widthPen;
        private Color color;
        public override int WidthPen
        {
            get { return widthPen; }
            set
            {
                widthPen = value;
                for (int i = 0; i < listShapesNew.Count; i++)
                {
                    listShapesNew[i].WidthPen = widthPen;
                }
            }
        }
        public override Color Color
        {
            get { return color; }
            set
            {
                color = value;
                for (int i = 0; i < listShapesNew.Count; i++)
                {
                    listShapesNew[i].Color = color;
                }
            }
        }
        public List<Shape> listShapesOld;
        public List<Shape> listShapesNew;

        public void ReSizeFigures()
        {
            for(int i = 0; i < listShapesNew.Count; i++)
            {
                listShapesNew[i].StartX = (listShapesOld[i].StartX * (FinishX - StartX)) / FinishXOld + StartX;
                listShapesNew[i].StartY = (listShapesOld[i].StartY * (FinishY - StartY)) / FinishYOld + StartY;
                listShapesNew[i].FinishX = (listShapesOld[i].FinishX * (FinishX - StartX)) / FinishXOld + StartX;
                listShapesNew[i].FinishY = (listShapesOld[i].FinishY * (FinishY - StartY)) / FinishYOld + StartY;
            }
        }
        public NewShape(int StartX, int StartY, int FinishX, int FinishY, List<Shape> listShapes)
        {
            if (listShapes != null)
            {
                listShapesOld = listShapes;
                listShapesNew = new List<Shape>();
                for (int i = 0; i < listShapes.Count; i++)
                {
                    listShapesNew.Add((Shape)(listShapes[i].Clone()));
                }
            }
            else
            {
                listShapesOld = new List<Shape>();
                listShapesNew = new List<Shape>();
            }
            FinishXOld = FinishX;
            FinishYOld = FinishY;
            this.StartX = StartX;
            this.StartY = StartY;
            this.FinishX = FinishX;
            this.FinishY = FinishY;
        }
        public override void Draw(PictureBox pictureBox)
        {
            ReSizeFigures();
            for(int i = 0; i < listShapesNew.Count; i++)
            {
                listShapesNew[i].Draw(pictureBox);
            }
        }
        public override bool Selectable(int mouseX, int mouseY)
        {
            bool select = false;
            for (int i = 0; i < listShapesNew.Count; i++)
            {
                if (listShapesNew[i].Selectable(mouseX, mouseY))
                {
                    select = true;
                }
            }
            return select;
        }
        public override object Clone()
        {
            List<Shape> listShapes = new List<Shape>();
            for (int i = 0; i < listShapesNew.Count; i++)
            {
                listShapes.Add((Shape)(listShapesNew[i].Clone()));
            }
            NewShape newShape = new NewShape(StartX, StartY, FinishX, FinishY, listShapes);
            return newShape;
        }
    }
}
