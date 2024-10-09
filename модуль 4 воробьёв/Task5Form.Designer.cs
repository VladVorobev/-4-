partial class Task5Form
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.Button btnDrawLine;
    private System.Windows.Forms.Button btnDrawCircle;
    private System.Windows.Forms.Button btnDrawRectangle;
    private System.Windows.Forms.Button btnClear; // Новая кнопка для очистки холста

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.btnDrawRectangle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(11, 11);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(570, 366);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackColor = System.Drawing.Color.Blue;
            this.btnDrawLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawLine.FlatAppearance.BorderSize = 0;
            this.btnDrawLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawLine.ForeColor = System.Drawing.Color.White;
            this.btnDrawLine.Location = new System.Drawing.Point(9, 390);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(113, 24);
            this.btnDrawLine.TabIndex = 1;
            this.btnDrawLine.Text = "Нарисовать линию";
            this.btnDrawLine.UseVisualStyleBackColor = false;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDrawCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawCircle.FlatAppearance.BorderSize = 0;
            this.btnDrawCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawCircle.ForeColor = System.Drawing.Color.White;
            this.btnDrawCircle.Location = new System.Drawing.Point(241, 390);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(103, 24);
            this.btnDrawCircle.TabIndex = 2;
            this.btnDrawCircle.Text = "Нарисовать круг";
            this.btnDrawCircle.UseVisualStyleBackColor = false;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // btnDrawRectangle
            // 
            this.btnDrawRectangle.BackColor = System.Drawing.Color.Green;
            this.btnDrawRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawRectangle.FlatAppearance.BorderSize = 0;
            this.btnDrawRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawRectangle.ForeColor = System.Drawing.Color.White;
            this.btnDrawRectangle.Location = new System.Drawing.Point(421, 390);
            this.btnDrawRectangle.Name = "btnDrawRectangle";
            this.btnDrawRectangle.Size = new System.Drawing.Size(158, 24);
            this.btnDrawRectangle.TabIndex = 3;
            this.btnDrawRectangle.Text = "Нарисовать прямоугольник";
            this.btnDrawRectangle.UseVisualStyleBackColor = false;
            this.btnDrawRectangle.Click += new System.EventHandler(this.btnDrawRectangle_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(9, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(570, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить холст";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Task5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::модуль_4_воробьёв.Properties.Resources.fon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 461);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDrawRectangle);
            this.Controls.Add(this.btnDrawCircle);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Task5Form";
            this.Text = "Приложение для рисования";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

    }
}