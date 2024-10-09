using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Task5Form : Form
{
    private Canvas _canvas;
    private Random _random; // Для генерации случайных чисел

    public Task5Form()
    {
        InitializeComponent();
        _canvas = new Canvas(pictureBox);
        _random = new Random(); // Инициализация генератора случайных чисел
    }

    private void btnDrawLine_Click(object sender, EventArgs e)
    {
        // Генерация случайных координат для линии
        int x1 = _random.Next(0, pictureBox.Width);
        int y1 = _random.Next(0, pictureBox.Height);
        int x2 = _random.Next(0, pictureBox.Width);
        int y2 = _random.Next(0, pictureBox.Height);

        _canvas.DrawLine(x1, y1, x2, y2);
    }

    private void btnDrawCircle_Click(object sender, EventArgs e)
    {
        // Генерация случайных координат и радиуса для круга
        int radius = _random.Next(10, Math.Min(pictureBox.Width, pictureBox.Height) / 2); // Случайный радиус от 10 до половины минимального размера

        int centerX = _random.Next(radius, pictureBox.Width - radius); // Обеспечиваем, что круг помещается внутри PictureBox
        int centerY = _random.Next(radius, pictureBox.Height - radius);

        _canvas.DrawCircle(centerX, centerY, radius);
    }

    private void btnDrawRectangle_Click(object sender, EventArgs e)
    {
        // Генерация случайных координат и размеров для прямоугольника
        int width = _random.Next(20, pictureBox.Width); // Случайная ширина от 20 до ширины PictureBox
        int height = _random.Next(20, pictureBox.Height); // Случайная высота от 20 до высоты PictureBox

        // Обеспечиваем, что прямоугольник помещается внутри PictureBox
        int x = _random.Next(0, pictureBox.Width - width);
        int y = _random.Next(0, pictureBox.Height - height);

        _canvas.DrawRectangle(x, y, width, height);
    }
    public void Clear()
    {
        using (Graphics g = pictureBox.CreateGraphics())
        {
            g.Clear(Color.White); // Очистка холста белым цветом
        }
    }
    private void btnClear_Click(object sender, EventArgs e) // Кнопка для очистки холста
    {
        _canvas.Clear();
    }
}