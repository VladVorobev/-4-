public interface IDrawing
{
    void DrawLine(int x1, int y1, int x2, int y2);
    void DrawCircle(int centerX, int centerY, int radius);
    void DrawRectangle(int x, int y, int width, int height);
}