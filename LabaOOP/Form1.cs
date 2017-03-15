using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using ShapeLibrary;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using InputBox;

namespace LabaOOP
{
    [Serializable]
    public partial class DrawFigures : Form
    {
        private List<Shape> shapes;
        private Dictionary<string, NewShape> newShapes;
        private string checkedFigure;
        private int startX;
        private int startY;
        private PictureBox pictureBox;
        private bool createFigure;
        Color color;
        private int widthPen;
        private int fieldSize;
        private static int startWidthForm = 800;
        private static int startHeightForm = 460;
        private static int startWidthBox = 650;
        private static int startHeightBox = 380;
        private int numberSelectionFigure;
        private int numberEditionFigure;
        private Point mouse;
        private ImportManager imports;
        private Dictionary<string, Type> typeOfFigures = new Dictionary<string, Type>();
        private int numberButton;
        KnownTypesBinder kBinder = new KnownTypesBinder();
        private string path = @"..\..\dll";
        private List<RadioButton> btnList;
        private string pachNewFigures = @"newFigures.json";

        public DrawFigures()
        {
            InitializeComponent();
            StartInitParams();
        }
        private void StartInitParams()
        {
            newShapes = new Dictionary<string, NewShape>();
            cb_Figures.Items.Add("Mouse");
            shapes = new List<Shape>();
            checkedFigure = "";
            startX = -1;
            startY = -1;
            pictureBox = pbSurfaceDraw;
            createFigure = false;
            color = Color.Black;
            widthPen = 3;
            fieldSize = 3;
            numberSelectionFigure = -1;
            numberSelectionFigure = -1;
            mouse = new Point(-1, -1);
            btnList = new List<RadioButton>();
            AddDll();
            LoadNewFigures();
        }
        private void LoadNewFigures()
        {
            try
            {                
                string json = File.ReadAllText(pachNewFigures);
                newShapes = JsonConvert.DeserializeObject<Dictionary<string, NewShape>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Binder = kBinder
                });
                AddNewShapes();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка при выполнении загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddNewShapes()
        {
            if (newShapes != null) {
                int N = newShapes.Count;
                string[] arrayNewShapes = new string[N];
                newShapes.Keys.CopyTo(arrayNewShapes, 0);
                for(int i = 0; i < N; i++)
                {
                    cb_Figures.Items.Add(arrayNewShapes[i]);
                }
            }
        }
        private void SaveNewFigures()
        {
            try
            {
                string json = JsonConvert.SerializeObject(newShapes, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Binder = kBinder
                });
                File.WriteAllText(pachNewFigures, json);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка при выполнении загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddDll()
        {
            try
            {
                numberButton = 0;
                List<Type> tempTypes = new List<Type>();
                var catalog = new DirectoryCatalog(path);
                var container = new CompositionContainer(catalog);
                imports = new ImportManager();
                container.ComposeParts(this, imports);
                foreach (var figure in imports.readerExtCollection)
                {
                    string nameFigure = figure.Value.GetType().ToString().Split('.')[0].Replace("Library", "");
                    typeOfFigures.Add(nameFigure, figure.Value.GetType());
                    CreateRadioButtonOnForm(nameFigure);
                    tempTypes.Add(figure.Value.GetType());
                    cb_Figures.Items.Add(nameFigure);
                }
                tempTypes.Add(shapes.GetType());
                tempTypes.Add(newShapes.GetType());
                tempTypes.Add((new NewShape(0, 0, 0, 0, null)).GetType());
                kBinder.KnownTypes = tempTypes;
            }
            catch { }
        }
        private void CreateRadioButtonOnForm(string name)
        {
            numberButton++;
            RadioButton rb = returnTamplateRadioButton();
            rb.Text = name;
            rb.Name = name;
            rb.Location = new Point(12, 30 * numberButton + 10);
            this.Controls.Add(rb);
            btnList.Add(rb);
        }
        private RadioButton returnTamplateRadioButton()
        {
            RadioButton rb = new RadioButton();
            rb.Click += new EventHandler(CheckFigure);
            return rb;
        }
        private void DrawAll()
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw(pictureBox);
            }
            DrawSelectionFigure(numberSelectionFigure);
        }
        private void FigOOP_Move(object sender, EventArgs e)
        {
            if (shapes.Count != 0)
            {
                DrawAll();
                numberSelectionFigure = -1;
            }
        }
        private void CheckFigure(object sender, EventArgs e)
        {
            checkedFigure = ((RadioButton)sender).Text;
            numberEditionFigure = -1;
            numberSelectionFigure = -1;
            DrawAll();
        }
        private void StartPaintFigure(object sender, MouseEventArgs e)
        {
            if (checkedFigure != "")
            {
                startX = e.X;
                startY = e.Y;
            }
            else
            {
                SetMouse(e.X, e.Y);
                SelectionFigure(e.X, e.Y);
            }
        }
        private void PaintFigure(object sender, MouseEventArgs e)
        {
            if ((checkedFigure != "") && (startX != -1) && (startY != -1))
            {
                if (!createFigure)
                {
                    shapes.Add(returnNewFigure(checkedFigure, startX, startY, e.X, e.Y, color, widthPen));
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
            else
            {
                if (numberSelectionFigure != -1)
                    if (mouseInSelectionFigure(e.X, e.Y))
                    {
                        int posMouse = mouseInBoardFigure(e.X, e.Y);
                        if (posMouse != -1)
                        {
                            Cursor = Cursors.Cross;
                            EditSizesFigure(e.X, e.Y, posMouse);
                        }
                        else
                        {
                            Cursor = Cursors.SizeAll;
                            EditPositionFigure(e.X, e.Y);
                        }
                        if (numberEditionFigure != -1)
                            DrawAll();
                    }
                    else
                        Cursor = Cursors.Default;

            }
        }
        private void EditSizesFigure(int x, int y, int posMouse)
        {
            if (numberEditionFigure != -1)
            {
                switch (posMouse)
                {
                    case 11: shapes[numberEditionFigure].FinishX += x - mouse.X; break;
                    case 12: shapes[numberEditionFigure].StartY += y - mouse.Y; break;
                    case 13: shapes[numberEditionFigure].StartX += x - mouse.X; break;
                    case 14: shapes[numberEditionFigure].FinishY += y - mouse.Y; break;
                    case 21: shapes[numberEditionFigure].FinishX += x - mouse.X; break;
                    case 22: shapes[numberEditionFigure].FinishY += y - mouse.Y; break;
                    case 23: shapes[numberEditionFigure].StartX += x - mouse.X; break;
                    case 24: shapes[numberEditionFigure].StartY += y - mouse.Y; break;
                    case 31: shapes[numberEditionFigure].StartX += x - mouse.X; break;
                    case 32: shapes[numberEditionFigure].StartY += y - mouse.Y; break;
                    case 33: shapes[numberEditionFigure].FinishX += x - mouse.X; break;
                    case 34: shapes[numberEditionFigure].FinishY += y - mouse.Y; break;
                    case 41: shapes[numberEditionFigure].StartX += x - mouse.X; break;
                    case 42: shapes[numberEditionFigure].FinishY += y - mouse.Y; break;
                    case 43: shapes[numberEditionFigure].FinishX += x - mouse.X; break;
                    case 44: shapes[numberEditionFigure].StartY += y - mouse.Y; break;
                }
                SetMouse(x, y);
            }
        }
        private void SetMouse(int x, int y)
        {
            mouse.X = x;
            mouse.Y = y;
        }
        private int mouseInBoardFigure(int mouseX, int mouseY)
        {
            const int space = 10;
            Point startP = new Point(shapes[numberSelectionFigure].StartX, shapes[numberSelectionFigure].StartY);
            Point finishP = new Point(shapes[numberSelectionFigure].FinishX, shapes[numberSelectionFigure].FinishY);
            if (((finishP.X - startP.X) > 0) && ((finishP.Y - startP.Y) > 0))
            {
                if ((finishP.X - mouseX) < space) return 11;
                if ((mouseY - startP.Y) < space) return 12;
                if ((mouseX - startP.X) < space) return 13;
                if ((finishP.Y - mouseY) < space) return 14;
            }
            if (((finishP.X - startP.X) > 0) && ((finishP.Y - startP.Y) < 0))
            {
                if ((finishP.X - mouseX) < space) return 21;
                if ((mouseY - finishP.Y) < space) return 22;
                if ((mouseX - startP.X) < space) return 23;
                if ((startP.Y - mouseY) < space) return 24;
            }
            if (((finishP.X - startP.X) < 0) && ((finishP.Y - startP.Y) > 0))
            {
                if ((startP.X - mouseX) < space) return 31;
                if ((mouseY - startP.Y) < space) return 32;
                if ((mouseX - finishP.X) < space) return 33;
                if ((finishP.Y - mouseY) < space) return 34;
            }
            if (((finishP.X - startP.X) < 0) && ((finishP.Y - startP.Y) < 0))
            {
                if ((startP.X - mouseX) < space) return 41;
                if ((mouseY - finishP.Y) < space) return 42;
                if ((mouseX - finishP.X) < space) return 43;
                if ((startP.Y - mouseY) < space) return 44;
            }
            return -1;
        }
        private void EditPositionFigure(int x, int y)
        {
            if (numberEditionFigure != -1)
            {
                shapes[numberEditionFigure].StartX += x - mouse.X;
                shapes[numberEditionFigure].StartY += y - mouse.Y;
                shapes[numberEditionFigure].FinishX += x - mouse.X;
                shapes[numberEditionFigure].FinishY += y - mouse.Y;
                SetMouse(x, y);
            }
        }
        private bool mouseInSelectionFigure(int mouseX, int mouseY)
        {
            Point startP = new Point(shapes[numberSelectionFigure].StartX, shapes[numberSelectionFigure].StartY);
            Point finishP = new Point(shapes[numberSelectionFigure].FinishX, shapes[numberSelectionFigure].FinishY);
            if (((finishP.X - startP.X) > 0) && ((finishP.Y - startP.Y) > 0))
                if ((mouseX > startP.X) && (mouseX < finishP.X) && (mouseY > startP.Y) && (mouseY < finishP.Y))
                    return true;
            if (((finishP.X - startP.X) > 0) && ((finishP.Y - startP.Y) < 0))
                if ((mouseX > startP.X) && (mouseX < finishP.X) && (mouseY < startP.Y) && (mouseY > finishP.Y))
                    return true;
            if (((finishP.X - startP.X) < 0) && ((finishP.Y - startP.Y) > 0))
                if ((mouseX < startP.X) && (mouseX > finishP.X) && (mouseY > startP.Y) && (mouseY < finishP.Y))
                    return true;
            if (((finishP.X - startP.X) < 0) && ((finishP.Y - startP.Y) < 0))
                if ((mouseX < startP.X) && (mouseX > finishP.X) && (mouseY < startP.Y) && (mouseY > finishP.Y))
                    return true;
            return false;
        }
        private void FinishPaintFigure(object sender, MouseEventArgs e)
        {
            startX = -1;
            startY = -1;
            createFigure = false;
            numberEditionFigure = -1;
        }
        private Shape returnNewFigure(string name, int startX, int startY, int finishX, int finishY, Color color, int widthPen)
        {
            if (typeOfFigures.ContainsKey(name))
            {
                Type typeFigure = typeOfFigures[name];
                return (Shape)Activator.CreateInstance(typeFigure, startX, startY, finishX, finishY, color, widthPen);
            }
            if (newShapes.ContainsKey(name))
            {
                NewShape temp = (NewShape)(newShapes[name].Clone());
                temp.StartX = startX;
                temp.StartY = startY;
                temp.FinishX = finishX;
                temp.FinishY = finishY;
                temp.Color = color;
                temp.WidthPen = widthPen;
                return (Shape)temp;
            }
            return null;
        }
        private void btnCheckColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                btnColorIndex.BackColor = color;
            }
            ChangeColor();
        }
        private void ChangeColor()
        {
            if (numberSelectionFigure != -1)
            {
                shapes[numberSelectionFigure].Color = color;
                DrawAll();
            }
        }
        private void widthPenNumeric_ValueChanged(object sender, EventArgs e)
        {
            widthPen = (int)widthPenNumeric.Value;
            ChangePenWidth();
        }
        private void ChangePenWidth()
        {
            if (numberSelectionFigure != -1)
            {
                shapes[numberSelectionFigure].WidthPen = widthPen;
                DrawAll();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                /*//binary
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fout = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    bf.Serialize(fout, shapes);
                }*/
                //json
                string json = JsonConvert.SerializeObject(shapes, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Binder = kBinder
                });
                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            DrawAll();
            numberEditionFigure = -1;
            numberSelectionFigure = -1;
            SetMouse(-1, -1);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //binary
                    /*BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fin = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        shapes = (List<Shape>)(bf.Deserialize(fin));
                    }*/
                    string json = File.ReadAllText(openFileDialog.FileName);
                    shapes = JsonConvert.DeserializeObject<List<Shape>>(json, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All,
                        Binder = kBinder
                    });
                }
                DrawAll();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка при выполнении загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            fieldSize = Convert.ToInt32(toolStripComboBox1.Text);
            UpdateWidthAndHeightFields();
        }
        private void UpdateWidthAndHeightFields()
        {
            int WidthForm = 0, HeightForm = 0, WidthBox = 0, HeightBox = 0;
            GetNewWidthAndHeightOfField(out WidthForm, out HeightForm, out WidthBox, out HeightBox);
            pictureBox.Width = WidthBox;
            pictureBox.Height = HeightBox;
            this.Width = WidthForm;
            this.Height = HeightForm;
        }
        private void GetNewWidthAndHeightOfField(out int WidthForm, out int HeightForm, out int WidthBox, out int HeightBox)
        {
            int addWidthForm = 0;
            int addHeightForm = 0;
            int addWidthBox = 0;
            int addHeightBox = 0;
            switch (fieldSize)
            {
                case 1:
                    addWidthForm = -200;
                    addHeightForm = 0;
                    addWidthBox = -200;
                    addHeightBox = 0;
                    break;
                case 2:
                    addWidthForm = -100;
                    addHeightForm = 0;
                    addWidthBox = -100;
                    addHeightBox = 0;
                    break;
                case 3:
                    addWidthForm = 0;
                    addHeightForm = 0;
                    addWidthBox = 0;
                    addHeightBox = 0;
                    break;
                case 4:
                    addWidthForm = 100;
                    addHeightForm = 50;
                    addWidthBox = 100;
                    addHeightBox = 50;
                    break;
                case 5:
                    addWidthForm = 200;
                    addHeightForm = 100;
                    addWidthBox = 200;
                    addHeightBox = 100;
                    break;
            }
            WidthBox = startWidthBox + addWidthBox;
            HeightBox = startHeightBox + addHeightBox;
            WidthForm = startWidthForm + addWidthForm;
            HeightForm = startHeightForm + addHeightForm;
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drawing choose the shape, the outline color and thickness of the outline in the left column. In order to draw the shape you need to hold down the left mouse button and not pressing until the shape reaches the desired size. There is also the possibility to save or load a picture clicked on file -> save/load and will clear the file->new.", "Help information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void CheckedMouse(object sender, EventArgs e)
        {
            checkedFigure = "";
        }
        private void SelectionFigure(int mouseX, int mouseY)
        {
            int indexSelectionFigure = -1;
            for (int i = 0; i < shapes.Count; i++)
                if (shapes[i].Selectable(mouseX, mouseY))
                    indexSelectionFigure = i;
            if (indexSelectionFigure != numberSelectionFigure)
            {
                numberSelectionFigure = indexSelectionFigure;
                DrawAll();
            }
            else
            {
                EditionFigure();
            }
        }
        private void EditionFigure()
        {
            numberEditionFigure = numberSelectionFigure;
        }
        private void DrawSelectionFigure(int indexSelectionFigure)
        {
            if (indexSelectionFigure != -1)
            {
                numberSelectionFigure = indexSelectionFigure;
                Graphics g = pictureBox.CreateGraphics();
                Pen pen = new Pen(Color.Gray, 1);
                Point startP = new Point(shapes[indexSelectionFigure].StartX, shapes[indexSelectionFigure].StartY);
                Point finishP = new Point(shapes[indexSelectionFigure].FinishX, shapes[indexSelectionFigure].FinishY);
                System.Drawing.Rectangle rect = RetRectOfPoints(startP, finishP);
                g.DrawRectangle(pen, rect);
            }
            else
            {
                numberSelectionFigure = -1;
            }
        }
        private System.Drawing.Rectangle RetRectOfPoints(Point startP, Point finishP)
        {
            Point startPR = startP;
            Point finishPR = finishP;
            if (((finishP.X - startP.X) > 0) && ((finishP.Y - startP.Y) < 0))
            {
                startPR.Y = finishP.Y;
                finishPR.Y = startP.Y;
            }
            if (((finishP.X - startP.X) < 0) && ((finishP.Y - startP.Y) > 0))
            {
                startPR.X = finishP.X;
                finishPR.X = startP.X;
            }
            if (((finishP.X - startP.X) < 0) && ((finishP.Y - startP.Y) < 0))
            {
                startPR = finishP;
                finishPR = startP;
            }
            return new System.Drawing.Rectangle(startPR.X, startPR.Y, finishPR.X - startPR.X, finishPR.Y - startPR.Y);
        }
        private void Mouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (numberSelectionFigure != -1)
            {
                switch (e.KeyChar)
                {
                    case 'w':
                    case 'W':
                    case 'ц':
                    case 'Ц': NextShape(); break;
                    case 's':
                    case 'S':
                    case 'ы':
                    case 'Ы': BackShape(); break;
                    case (char)8: DeleteShape(); break;
                }
            }
        }
        private void DeleteShape()
        {
            shapes.RemoveAt(numberSelectionFigure);
            numberSelectionFigure = -1;
            DrawAll();
        }
        private void BackShape()
        {
            if (numberSelectionFigure == 0)
                numberSelectionFigure = shapes.Count - 1;
            else
                numberSelectionFigure = numberSelectionFigure - 1;
            DrawAll();
        }
        private void NextShape()
        {
            numberSelectionFigure = (numberSelectionFigure + 1) % shapes.Count;
            DrawAll();
        }
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFiguresButtons();
            btnList.Clear();
            AddDll();
        }
        private void DeleteFiguresButtons()
        {
            if (btnList != null)
            {
                for (int i = 0; i < btnList.Count; i++)
                {
                    this.Controls.Remove(btnList[i]);
                }
            }
            cb_Figures.Items.Clear();
            cb_Figures.Items.Add("Mouse");
        }
        private void cb_Figures_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkedFigure == "Mouse")
            {
                if (numberSelectionFigure != -1)
                {
                    switch (e.KeyChar)
                    {
                        case 'w':
                        case 'W':
                        case 'ц':
                        case 'Ц': NextShape(); break;
                        case 's':
                        case 'S':
                        case 'ы':
                        case 'Ы': BackShape(); break;
                        case (char)8: DeleteShape(); break;
                    }
                }
            }
        }
        private void cb_Figures_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedFigure = ((ComboBox)sender).Text;
            if (checkedFigure != "Mouse")
            {
                numberEditionFigure = -1;
                numberSelectionFigure = -1;
                DrawAll();
            }
            else
            {
                checkedFigure = "";
            }
        }
        private void createNewFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewShape newShape = new NewShape(0, 0, pictureBox.Width, pictureBox.Height, shapes);
            InputBox.InputBox inputBox = new InputBox.InputBox();
            inputBox.TextMessage = "Input name:";
            string nameNewShape = inputBox.getString();
            if (!CheckNameFigure(nameNewShape))
            {
                MessageBox.Show("Shape cann't create, because this name exist!", "Error create new shape", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nameNewShape == "")
            {
                MessageBox.Show("Shape cann't create, because you don't pointer name!", "Error create new shape", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            newShapes.Add(nameNewShape, (NewShape)(newShape.Clone()));
            cb_Figures.Items.Add(nameNewShape);
            SaveNewFigures();
        }
        private bool CheckNameFigure(string nameNewShape)
        {
            if (typeOfFigures.ContainsKey(nameNewShape))
            {
                return false;
            }
            if (newShapes.ContainsKey(nameNewShape))
            {
                return false;
            }
            return true;
        }
    }
}
