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
            this.btnDraw = new System.Windows.Forms.Button();
            this.pbSurfaceDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(23, 23);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(111, 84);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pbSurfaceDraw
            // 
            this.pbSurfaceDraw.Location = new System.Drawing.Point(158, 12);
            this.pbSurfaceDraw.Name = "pbSurfaceDraw";
            this.pbSurfaceDraw.Size = new System.Drawing.Size(670, 360);
            this.pbSurfaceDraw.TabIndex = 2;
            this.pbSurfaceDraw.TabStop = false;
            // 
            // DrawFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 384);
            this.Controls.Add(this.pbSurfaceDraw);
            this.Controls.Add(this.btnDraw);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DrawFigures";
            this.Text = "DrawFigures";
            this.Move += new System.EventHandler(this.FigOOP_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox pbSurfaceDraw;
    }
}

