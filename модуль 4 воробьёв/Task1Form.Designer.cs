using System.Windows.Forms;

namespace модуль_4_воробьёв
{
    partial class Task1Form
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCircle = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalculateCircle = new System.Windows.Forms.Button();
            this.lblRectangle = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculateRectangle = new System.Windows.Forms.Button();
            this.lblTriangle = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.btnCalculateTriangle = new System.Windows.Forms.Button();
            this.lblCircleResult = new System.Windows.Forms.Label();
            this.lblRectangleResult = new System.Windows.Forms.Label();
            this.lblTriangleResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(128, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Вычисление площади и периметра";
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblCircle
            // 
            this.lblCircle.AutoSize = true;
            this.lblCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCircle.Location = new System.Drawing.Point(22, 52);
            this.lblCircle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(112, 16);
            this.lblCircle.TabIndex = 1;
            this.lblCircle.Text = "Круг (радиус):";
            this.lblCircle.BackColor = System.Drawing.Color.Transparent;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(138, 50);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(2);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(118, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // btnCalculateCircle
            // 
            this.btnCalculateCircle.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalculateCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateCircle.FlatAppearance.BorderSize = 0;
            this.btnCalculateCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCircle.Location = new System.Drawing.Point(269, 50);
            this.btnCalculateCircle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateCircle.Name = "btnCalculateCircle";
            this.btnCalculateCircle.Size = new System.Drawing.Size(110, 20);
            this.btnCalculateCircle.TabIndex = 3;
            this.btnCalculateCircle.Text = "Вычислить";
            this.btnCalculateCircle.UseVisualStyleBackColor = false;
            this.btnCalculateCircle.MouseEnter += new System.EventHandler(this.btnCalculateCircle_MouseEnter);
            this.btnCalculateCircle.MouseLeave += new System.EventHandler(this.btnCalculateCircle_MouseLeave);
            // 
            // lblRectangle
            // 
            this.lblRectangle.AutoSize = true;
            this.lblRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRectangle.Location = new System.Drawing.Point(22, 104);
            this.lblRectangle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(248, 16);
            this.lblRectangle.TabIndex = 4;
            this.lblRectangle.Text = "Прямоугольник (длина, ширина):";
            this.lblRectangle.BackColor = System.Drawing.Color.Transparent;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(274, 100);
            this.txtLength.Margin = new System.Windows.Forms.Padding(2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(107, 20);
            this.txtLength.TabIndex = 5;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(385, 100);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(110, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // btnCalculateRectangle
            // 
            this.btnCalculateRectangle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculateRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateRectangle.FlatAppearance.BorderSize = 0;
            this.btnCalculateRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateRectangle.Location = new System.Drawing.Point(499, 100);
            this.btnCalculateRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateRectangle.Name = "btnCalculateRectangle";
            this.btnCalculateRectangle.Size = new System.Drawing.Size(110, 20);
            this.btnCalculateRectangle.TabIndex = 7;
            this.btnCalculateRectangle.Text = "Вычислить";
            this.btnCalculateRectangle.UseVisualStyleBackColor = false;
            this.btnCalculateRectangle.MouseEnter += new System.EventHandler(this.btnCalculateRectangle_MouseEnter);
            this.btnCalculateRectangle.MouseLeave += new System.EventHandler(this.btnCalculateRectangle_MouseLeave);
            // 
            // lblTriangle
            // 
            this.lblTriangle.AutoSize = true;
            this.lblTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTriangle.Location = new System.Drawing.Point(22, 156);
            this.lblTriangle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(233, 16);
            this.lblTriangle.TabIndex = 8;
            this.lblTriangle.Text = "Треугольник (стороны A, B, C):";
            this.lblTriangle.BackColor = System.Drawing.Color.Transparent;
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(259, 154);
            this.txtSideA.Margin = new System.Windows.Forms.Padding(2);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(76, 20);
            this.txtSideA.TabIndex = 9;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(339, 154);
            this.txtSideB.Margin = new System.Windows.Forms.Padding(2);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(76, 20);
            this.txtSideB.TabIndex = 10;
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(419, 154);
            this.txtSideC.Margin = new System.Windows.Forms.Padding(2);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(76, 20);
            this.txtSideC.TabIndex = 11;
            // 
            // btnCalculateTriangle
            // 
            this.btnCalculateTriangle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalculateTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateTriangle.FlatAppearance.BorderSize = 0;
            this.btnCalculateTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateTriangle.Location = new System.Drawing.Point(499, 154);
            this.btnCalculateTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateTriangle.Name = "btnCalculateTriangle";
            this.btnCalculateTriangle.Size = new System.Drawing.Size(110, 20);
            this.btnCalculateTriangle.TabIndex = 12;
            this.btnCalculateTriangle.Text = "Вычислить";
            this.btnCalculateTriangle.UseVisualStyleBackColor = false;
            this.btnCalculateTriangle.MouseEnter += new System.EventHandler(this.btnCalculateTriangle_MouseEnter);
            this.btnCalculateTriangle.MouseLeave += new System.EventHandler(this.btnCalculateTriangle_MouseLeave);
            // 
            // lblCircleResult
            // 
            this.lblCircleResult.AutoSize = true;
            this.lblCircleResult.Location = new System.Drawing.Point(22, 78);
            this.lblCircleResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCircleResult.Name = "lblCircleResult";
            this.lblCircleResult.Size = new System.Drawing.Size(0, 13);
            this.lblCircleResult.TabIndex = 13;
            // 
            // lblRectangleResult
            // 
            this.lblRectangleResult.AutoSize = true;
            this.lblRectangleResult.Location = new System.Drawing.Point(22, 117);
            this.lblRectangleResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRectangleResult.Name = "lblRectangleResult";
            this.lblRectangleResult.Size = new System.Drawing.Size(0, 13);
            this.lblRectangleResult.TabIndex = 14;
            // 
            // lblTriangleResult
            // 
            this.lblTriangleResult.AutoSize = true;
            this.lblTriangleResult.Location = new System.Drawing.Point(22, 156);
            this.lblTriangleResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriangleResult.Name = "lblTriangleResult";
            this.lblTriangleResult.Size = new System.Drawing.Size(0, 13);
            this.lblTriangleResult.TabIndex = 15;
            // 
            // Task1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::модуль_4_воробьёв.Properties.Resources.fon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 224);
            this.Controls.Add(this.lblTriangleResult);
            this.Controls.Add(this.lblRectangleResult);
            this.Controls.Add(this.lblCircleResult);
            this.Controls.Add(this.btnCalculateTriangle);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.lblTriangle);
            this.Controls.Add(this.btnCalculateRectangle);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblRectangle);
            this.Controls.Add(this.btnCalculateCircle);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblCircle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Task1Form";
            this.Text = "Task1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Label lblTriangle;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button btnCalculateCircle;
        private System.Windows.Forms.Button btnCalculateRectangle;
        private System.Windows.Forms.Button btnCalculateTriangle;
        private System.Windows.Forms.Label lblCircleResult;
        private System.Windows.Forms.Label lblRectangleResult;
        private System.Windows.Forms.Label lblTriangleResult;
    }
}



