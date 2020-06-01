namespace Lab9_Circles
{
    partial class Paint
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liveTime = new System.Windows.Forms.NumericUpDown();
            this.maxCnt = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liveTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.67857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.86224F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19898F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.14894F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.liveTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maxCnt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.start, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stop, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.drawBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Среднее время жизни окружности (сек):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Максимальное количество окружностей:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // liveTime
            // 
            this.liveTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liveTime.Location = new System.Drawing.Point(307, 3);
            this.liveTime.Name = "liveTime";
            this.liveTime.Size = new System.Drawing.Size(62, 30);
            this.liveTime.TabIndex = 4;
            this.liveTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.liveTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // maxCnt
            // 
            this.maxCnt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.maxCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxCnt.Location = new System.Drawing.Point(307, 34);
            this.maxCnt.Name = "maxCnt";
            this.maxCnt.Size = new System.Drawing.Size(62, 30);
            this.maxCnt.TabIndex = 5;
            this.maxCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxCnt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start.Location = new System.Drawing.Point(468, 3);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(107, 25);
            this.start.TabIndex = 6;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stop.Location = new System.Drawing.Point(468, 34);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(107, 25);
            this.stop.TabIndex = 7;
            this.stop.Text = "Стоп";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.Color.Black;
            this.drawBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.drawBox, 4);
            this.drawBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawBox.Location = new System.Drawing.Point(3, 65);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(572, 326);
            this.drawBox.TabIndex = 8;
            this.drawBox.TabStop = false;
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Paint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Paint";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liveTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown liveTime;
        private System.Windows.Forms.NumericUpDown maxCnt;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox drawBox;
    }
}

