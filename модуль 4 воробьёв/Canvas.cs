using System.Drawing;
using System.Windows.Forms;

public class Canvas : IDrawing
{
    private Graphics _graphics;
    private PictureBox _pictureBox;

    public Canvas(PictureBox pictureBox)
    {
        _pictureBox = pictureBox;
        _graphics = pictureBox.CreateGraphics();
    }

    public void DrawLine(int x1, int y1, int x2, int y2)
    {
        _graphics.DrawLine(Pens.Black, x1, y1, x2, y2);
    }

    public void DrawCircle(int centerX, int centerY, int radius)
    {
        _graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
    }

    public void DrawRectangle(int x, int y, int width, int height)
    {
        _graphics.DrawRectangle(Pens.Black, x, y, width, height);
    }

    public void Clear()
    {
        _graphics.Clear(Color.White);
    }
}