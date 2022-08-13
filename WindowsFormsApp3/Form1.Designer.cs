namespace WindowsFormsApp3
{
    partial class Form1
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
            this.sheet = new System.Windows.Forms.PictureBox();
            this.VertexB = new System.Windows.Forms.Button();
            this.SelectB = new System.Windows.Forms.Button();
            this.EdgeB = new System.Windows.Forms.Button();
            this.Shw = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.Control;
            this.sheet.Location = new System.Drawing.Point(0, 0);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(551, 596);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // VertexB
            // 
            this.VertexB.BackColor = System.Drawing.SystemColors.GrayText;
            this.VertexB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.VertexB.Location = new System.Drawing.Point(587, 77);
            this.VertexB.Name = "VertexB";
            this.VertexB.Size = new System.Drawing.Size(213, 35);
            this.VertexB.TabIndex = 1;
            this.VertexB.Text = "Добавить город (вершина)";
            this.VertexB.UseVisualStyleBackColor = false;
            this.VertexB.Click += new System.EventHandler(this.VertexB_Click);
            // 
            // SelectB
            // 
            this.SelectB.BackColor = System.Drawing.SystemColors.GrayText;
            this.SelectB.FlatAppearance.BorderColor = System.Drawing.Color.Ivory;
            this.SelectB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SelectB.Location = new System.Drawing.Point(587, 27);
            this.SelectB.Name = "SelectB";
            this.SelectB.Size = new System.Drawing.Size(213, 34);
            this.SelectB.TabIndex = 2;
            this.SelectB.Text = "Сброс кнопок";
            this.SelectB.UseVisualStyleBackColor = false;
            this.SelectB.Click += new System.EventHandler(this.SelectB_Click);
            // 
            // EdgeB
            // 
            this.EdgeB.BackColor = System.Drawing.SystemColors.GrayText;
            this.EdgeB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.EdgeB.Location = new System.Drawing.Point(587, 127);
            this.EdgeB.Name = "EdgeB";
            this.EdgeB.Size = new System.Drawing.Size(213, 35);
            this.EdgeB.TabIndex = 3;
            this.EdgeB.Text = "Добавить дорогу (ребро)";
            this.EdgeB.UseVisualStyleBackColor = false;
            this.EdgeB.Click += new System.EventHandler(this.EdgeB_Click);
            // 
            // Shw
            // 
            this.Shw.BackColor = System.Drawing.SystemColors.GrayText;
            this.Shw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Shw.Location = new System.Drawing.Point(898, 505);
            this.Shw.Name = "Shw";
            this.Shw.Size = new System.Drawing.Size(112, 42);
            this.Shw.TabIndex = 7;
            this.Shw.Text = "Найти путь";
            this.Shw.UseVisualStyleBackColor = false;
            this.Shw.Click += new System.EventHandler(this.Shw_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(898, 430);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(768, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исходная точка";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(587, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "О программе";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background_texture_2110724__340;
            this.ClientSize = new System.Drawing.Size(1022, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Shw);
            this.Controls.Add(this.EdgeB);
            this.Controls.Add(this.SelectB);
            this.Controls.Add(this.VertexB);
            this.Controls.Add(this.sheet);
            this.Name = "Form1";
            this.Text = "Графы";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VertexB;
        private System.Windows.Forms.Button SelectB;
        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button EdgeB;
        private System.Windows.Forms.Button Shw;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

