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
        private List<IShape> shapes;
        public DrawFigures()
        {
            InitializeComponent();
            shapes = new List<IShape>();
        }
        private void StartInitShapes()
        {
            shapes.Clear();
            shapes.Add(new Rectangle(50, 50, 100, 300, Color.Red, pbSurfaceDraw));
            shapes.Add(new Square(50, 50, 200, 200, Color.Black, pbSurfaceDraw));
            shapes.Add(new Circle(50, 50, 100, 100, Color.Green, pbSurfaceDraw));
            shapes.Add(new Line(50, 50, 200, 200, Color.Orange, pbSurfaceDraw));
            shapes.Add(new Ellipse(200, 200, 300, 350, Color.Gray, pbSurfaceDraw));
            shapes.Add(new EquilateralTriangle(200, 200, 300, 350, Color.Brown, pbSurfaceDraw));
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            StartInitShapes();
            DrawAll();
        }
        private void DrawAll()
        {
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
    }
}
