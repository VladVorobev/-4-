using System;
using System.Windows.Forms;

namespace модуль_4_воробьёв
{
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
            this.btnCalculateCircle.Click += new System.EventHandler(this.btnCalculateCircle_Click);
            this.btnCalculateRectangle.Click += new System.EventHandler(this.btnCalculateRectangle_Click);
            this.btnCalculateTriangle.Click += new System.EventHandler(this.btnCalculateTriangle_Click);

        }

        private void btnCalculateCircle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadius.Text, out double radius))
            {
                Circle circle = new Circle(radius);
                double area = circle.CalculateArea();
                double perimeter = circle.CalculatePerimeter();
                MessageBox.Show($"Для круга:\nПлощадь: {area:F2}\nПериметр: {perimeter:F2}", "Результаты вычисления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Введите корректное значение радиуса.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalculateCircle_MouseEnter(object sender, EventArgs e)
        {
            this.btnCalculateCircle.BackColor = System.Drawing.Color.Coral;
            this.btnCalculateCircle.ForeColor = System.Drawing.Color.White;
        }

        private void btnCalculateCircle_MouseLeave(object sender, EventArgs e)
        {
            this.btnCalculateCircle.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalculateCircle.ForeColor = System.Drawing.Color.Black;
        }
        private void btnCalculateRectangle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLength.Text, out double length) && double.TryParse(txtWidth.Text, out double width))
            {
                Rectangle rectangle = new Rectangle(length, width);
                double area = rectangle.CalculateArea();
                double perimeter = rectangle.CalculatePerimeter();
                MessageBox.Show($"Для прямоугольника:\nПлощадь: {area:F2}\nПериметр: {perimeter:F2}", "Результаты вычисления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Введите корректные значения длины и ширины.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalculateRectangle_MouseEnter(object sender, EventArgs e)
        {
            this.btnCalculateRectangle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCalculateRectangle.ForeColor = System.Drawing.Color.White; 
        }

        private void btnCalculateRectangle_MouseLeave(object sender, EventArgs e)
        {
            this.btnCalculateRectangle.BackColor = System.Drawing.Color.LightSkyBlue; 
            this.btnCalculateRectangle.ForeColor = System.Drawing.Color.Black; 
        }
        private void btnCalculateTriangle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSideA.Text, out double sideA) &&
                double.TryParse(txtSideB.Text, out double sideB) &&
                double.TryParse(txtSideC.Text, out double sideC))
            {
                Triangle triangle = new Triangle(sideA, sideB, sideC);
                double area = triangle.CalculateArea();
                double perimeter = triangle.CalculatePerimeter();
                MessageBox.Show($"Для треугольника:\nПлощадь: {area:F2}\nПериметр: {perimeter:F2}", "Результаты вычисления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Введите корректные значения сторон треугольника.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalculateTriangle_MouseEnter(object sender, EventArgs e)
        {
            this.btnCalculateTriangle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCalculateTriangle.ForeColor = System.Drawing.Color.White;
        }
        private void btnCalculateTriangle_MouseLeave(object sender, EventArgs e)
        {
            this.btnCalculateTriangle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalculateTriangle.ForeColor = System.Drawing.Color.Black;
        }
    }
}