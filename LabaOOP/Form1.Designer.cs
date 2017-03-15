namespace LabaOOP
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
            this.createNewFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSurfaceDraw = new System.Windows.Forms.PictureBox();
            this.cb_Figures = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthPenNumeric)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColorIndex
            // 
            this.btnColorIndex.BackColor = System.Drawing.Color.Black;
            this.btnColorIndex.Enabled = false;
            this.btnColorIndex.Location = new System.Drawing.Point(47, 186);
            this.btnColorIndex.Name = "btnColorIndex";
            this.btnColorIndex.Size = new System.Drawing.Size(25, 25);
            this.btnColorIndex.TabIndex = 9;
            this.btnColorIndex.UseVisualStyleBackColor = false;
            // 
            // btnCheckColor
            // 
            this.btnCheckColor.Location = new System.Drawing.Point(12, 132);
            this.btnCheckColor.Name = "btnCheckColor";
            this.btnCheckColor.Size = new System.Drawing.Size(101, 48);
            this.btnCheckColor.TabIndex = 10;
            this.btnCheckColor.Text = "Color";
            this.btnCheckColor.UseVisualStyleBackColor = true;
            this.btnCheckColor.Click += new System.EventHandler(this.btnCheckColor_Click);
            // 
            // widthPenNumeric
            // 
            this.widthPenNumeric.Location = new System.Drawing.Point(12, 97);
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
            this.label1.Location = new System.Drawing.Point(33, 73);
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
            this.toolStripComboBox1,
            this.createNewFigureToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fieldSizeToolStripMenuItem
            // 
            this.fieldSizeToolStripMenuItem.Enabled = false;
            this.fieldSizeToolStripMenuItem.Name = "fieldSizeToolStripMenuItem";
            this.fieldSizeToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
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
            // createNewFigureToolStripMenuItem
            // 
            this.createNewFigureToolStripMenuItem.Name = "createNewFigureToolStripMenuItem";
            this.createNewFigureToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.createNewFigureToolStripMenuItem.Text = "Create new figure";
            this.createNewFigureToolStripMenuItem.Click += new System.EventHandler(this.createNewFigureToolStripMenuItem_Click);
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
            this.pbSurfaceDraw.Size = new System.Drawing.Size(650, 380);
            this.pbSurfaceDraw.TabIndex = 2;
            this.pbSurfaceDraw.TabStop = false;
            this.pbSurfaceDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartPaintFigure);
            this.pbSurfaceDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintFigure);
            this.pbSurfaceDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FinishPaintFigure);
            // 
            // cb_Figures
            // 
            this.cb_Figures.FormattingEnabled = true;
            this.cb_Figures.Location = new System.Drawing.Point(12, 34);
            this.cb_Figures.Name = "cb_Figures";
            this.cb_Figures.Size = new System.Drawing.Size(106, 29);
            this.cb_Figures.TabIndex = 15;
            this.cb_Figures.SelectedIndexChanged += new System.EventHandler(this.cb_Figures_SelectedIndexChanged);
            this.cb_Figures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Figures_KeyPress);
            // 
            // DrawFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.cb_Figures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthPenNumeric);
            this.Controls.Add(this.btnCheckColor);
            this.Controls.Add(this.btnColorIndex);
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
        private System.Windows.Forms.ComboBox cb_Figures;
        private System.Windows.Forms.ToolStripMenuItem createNewFigureToolStripMenuItem;
    }
}

