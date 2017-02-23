﻿namespace LabaOOP
{
    partial class DrawFigures
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.EquilateralTriangle = new System.Windows.Forms.RadioButton();
            this.btnColorIndex = new System.Windows.Forms.Button();
            this.btnCheckColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.widthPenNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSurfaceDraw = new System.Windows.Forms.PictureBox();
            this.Mouse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.widthPenNumeric)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(12, 34);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(77, 25);
            this.Ellipse.TabIndex = 3;
            this.Ellipse.TabStop = true;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.CheckFigure);
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(12, 65);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(72, 25);
            this.Circle.TabIndex = 4;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.CheckFigure);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(12, 96);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(80, 25);
            this.Square.TabIndex = 5;
            this.Square.TabStop = true;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.CheckFigure);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(12, 127);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(101, 25);
            this.Rectangle.TabIndex = 6;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.CheckFigure);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(12, 158);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(60, 25);
            this.Line.TabIndex = 7;
            this.Line.TabStop = true;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.CheckFigure);
            // 
            // EquilateralTriangle
            // 
            this.EquilateralTriangle.AutoSize = true;
            this.EquilateralTriangle.Location = new System.Drawing.Point(12, 189);
            this.EquilateralTriangle.Name = "EquilateralTriangle";
            this.EquilateralTriangle.Size = new System.Drawing.Size(87, 25);
            this.EquilateralTriangle.TabIndex = 8;
            this.EquilateralTriangle.TabStop = true;
            this.EquilateralTriangle.Text = "Triangle";
            this.EquilateralTriangle.UseVisualStyleBackColor = true;
            this.EquilateralTriangle.Click += new System.EventHandler(this.CheckFigure);
            // 
            // btnColorIndex
            // 
            this.btnColorIndex.BackColor = System.Drawing.Color.Black;
            this.btnColorIndex.Enabled = false;
            this.btnColorIndex.Location = new System.Drawing.Point(47, 361);
            this.btnColorIndex.Name = "btnColorIndex";
            this.btnColorIndex.Size = new System.Drawing.Size(25, 25);
            this.btnColorIndex.TabIndex = 9;
            this.btnColorIndex.UseVisualStyleBackColor = false;
            // 
            // btnCheckColor
            // 
            this.btnCheckColor.Location = new System.Drawing.Point(12, 307);
            this.btnCheckColor.Name = "btnCheckColor";
            this.btnCheckColor.Size = new System.Drawing.Size(101, 48);
            this.btnCheckColor.TabIndex = 10;
            this.btnCheckColor.Text = "Color";
            this.btnCheckColor.UseVisualStyleBackColor = true;
            this.btnCheckColor.Click += new System.EventHandler(this.btnCheckColor_Click);
            // 
            // widthPenNumeric
            // 
            this.widthPenNumeric.Location = new System.Drawing.Point(12, 272);
            this.widthPenNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthPenNumeric.Name = "widthPenNumeric";
            this.widthPenNumeric.Size = new System.Drawing.Size(101, 29);
            this.widthPenNumeric.TabIndex = 11;
            this.widthPenNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.widthPenNumeric.ValueChanged += new System.EventHandler(this.widthPenNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Width:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(49, 25);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::LabaOOP.Properties.Resources.clear1;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = global::LabaOOP.Properties.Resources.save1;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Image = global::LabaOOP.Properties.Resources.load1;
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Image = global::LabaOOP.Properties.Resources.exit1;
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieldSizeToolStripMenuItem,
            this.toolStripComboBox1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fieldSizeToolStripMenuItem
            // 
            this.fieldSizeToolStripMenuItem.Enabled = false;
            this.fieldSizeToolStripMenuItem.Name = "fieldSizeToolStripMenuItem";
            this.fieldSizeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fieldSizeToolStripMenuItem.Text = "Field size:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "3";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pbSurfaceDraw
            // 
            this.pbSurfaceDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSurfaceDraw.Location = new System.Drawing.Point(124, 34);
            this.pbSurfaceDraw.Name = "pbSurfaceDraw";
            this.pbSurfaceDraw.Size = new System.Drawing.Size(650, 350);
            this.pbSurfaceDraw.TabIndex = 2;
            this.pbSurfaceDraw.TabStop = false;
            this.pbSurfaceDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartPaintFigure);
            this.pbSurfaceDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintFigure);
            this.pbSurfaceDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FinishPaintFigure);
            // 
            // Mouse
            // 
            this.Mouse.AutoSize = true;
            this.Mouse.Location = new System.Drawing.Point(12, 220);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(79, 25);
            this.Mouse.TabIndex = 14;
            this.Mouse.Text = "Mouse";
            this.Mouse.UseVisualStyleBackColor = true;
            this.Mouse.Click += new System.EventHandler(this.CheckedMouse);
            this.Mouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mouse_KeyPress);
            // 
            // DrawFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 391);
            this.Controls.Add(this.Mouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthPenNumeric);
            this.Controls.Add(this.btnCheckColor);
            this.Controls.Add(this.btnColorIndex);
            this.Controls.Add(this.EquilateralTriangle);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.pbSurfaceDraw);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DrawFigures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawFigures";
            this.Move += new System.EventHandler(this.FigOOP_Move);
            ((System.ComponentModel.ISupportInitialize)(this.widthPenNumeric)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSurfaceDraw;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton EquilateralTriangle;
        private System.Windows.Forms.Button btnColorIndex;
        private System.Windows.Forms.Button btnCheckColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown widthPenNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RadioButton Mouse;
    }
}

