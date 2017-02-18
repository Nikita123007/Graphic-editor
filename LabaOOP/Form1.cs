using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOOP
{
    public partial class DrawFigures : Form
    {
        private List<Shape> shapes;
        private string checkedFigure;
        private int startX;
        private int startY;
        private PictureBox pictureBox;
        private bool createFigure;
        Color color;

        public DrawFigures()
        {
            InitializeComponent();
            StartInitParams();
        }
        private void StartInitParams()
        {
            shapes = new List<Shape>();
            checkedFigure = "";
            startX = -1;
            startY = -1;
            pictureBox = pbSurfaceDraw;
            createFigure = false;
            color = Color.Black;
        }
        private void DrawAll()
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }
        }
        private void FigOOP_Move(object sender, EventArgs e)
        {
            if (shapes.Count != 0)
            {
                DrawAll();
            }
        }
        private void CheckFigure(object sender, EventArgs e)
        {
            checkedFigure = ((RadioButton)sender).Text;
        }
        private void StartPaintFigure(object sender, MouseEventArgs e)
        {
            if (checkedFigure != "")
            {
                startX = e.X;
                startY = e.Y;
            }
        }
        private void PaintFigure(object sender, MouseEventArgs e)
        {
            if ((checkedFigure != "") && (startX != -1) && (startY != -1))
            {
                if (!createFigure) {
                    shapes.Add(returnNewFigure(checkedFigure, startX, startY, e.X, e.Y, color, pictureBox));
                    createFigure = true;
                }
                else
                {
                    int index = shapes.Count - 1;
                    shapes[index].FinishX = e.X;
                    shapes[index].FinishY = e.Y;
                }
                DrawAll();
            }
        }
        private void FinishPaintFigure(object sender, MouseEventArgs e)
        {
            startX = -1;
            startY = -1;
            createFigure = false;
        }
        private Shape returnNewFigure(string name, int startX, int startY, int finishX, int finishY, Color color, PictureBox pictureBox)
        {
            Type type = Type.GetType("LabaOOP." + name);
            return (Shape)Activator.CreateInstance(type, startX, startY, finishX, finishY, color, pictureBox);
        }
        private void btnCheckColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                btnColorIndex.BackColor = color;
            }
        }
    }
}
