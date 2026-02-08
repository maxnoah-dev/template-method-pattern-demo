namespace Lab03.Bai2_Triangle;

/// <summary>
/// Lớp trừu tượng tam giác với Template Method Draw().
/// Bước điều chỉnh điểm thứ 3 (AdjustThirdPoint) phải thực hiện trước khi vẽ.
/// </summary>
public abstract class Triangle
{
    public Point2D A { get; protected set; }
    public Point2D B { get; protected set; }
    public Point2D C { get; protected set; }

    protected Triangle(Point2D a, Point2D b, Point2D c)
    {
        A = a;
        B = b;
        C = c;
    }

    /// <summary>
    /// Template Method: điều chỉnh điểm C (hook) rồi vẽ ra console bằng dấu *.
    /// </summary>
    public void Draw()
    {
        AdjustThirdPoint();
        DrawToConsole();
    }

    /// <summary>
    /// Hook: di chuyển điểm C để tam giác thỏa tính chất (vuông, cân, đều).
    /// Lớp con ghi đè nếu cần.
    /// </summary>
    protected virtual void AdjustThirdPoint()
    {
        // Tam giác thường: không thay đổi C
    }

    /// <summary>
    /// Vẽ tam giác ra console bằng các dấu * (dùng chung cho mọi loại tam giác).
    /// </summary>
    private void DrawToConsole()
    {
        const int width = 41;
        const int height = 21;
        var grid = new bool[width, height];

        // Map tọa độ thực (A,B,C) vào lưới [0..width-1] x [0..height-1]
        double minX = Math.Min(Math.Min(A.X, B.X), C.X);
        double maxX = Math.Max(Math.Max(A.X, B.X), C.X);
        double minY = Math.Min(Math.Min(A.Y, B.Y), C.Y);
        double maxY = Math.Max(Math.Max(A.Y, B.Y), C.Y);
        double spanX = maxX - minX;
        double spanY = maxY - minY;
        if (spanX < 0.001) spanX = 1;
        if (spanY < 0.001) spanY = 1;

        int ToCol(double x) => (int)Math.Round((x - minX) / spanX * (width - 1));
        int ToRow(double y) => (int)Math.Round((y - minY) / spanY * (height - 1));

        DrawLine(grid, ToCol(A.X), ToRow(A.Y), ToCol(B.X), ToRow(B.Y));
        DrawLine(grid, ToCol(B.X), ToRow(B.Y), ToCol(C.X), ToRow(C.Y));
        DrawLine(grid, ToCol(C.X), ToRow(C.Y), ToCol(A.X), ToRow(A.Y));

        for (int r = 0; r < height; r++)
        {
            for (int c = 0; c < width; c++)
                Console.Write(grid[c, r] ? '*' : ' ');
            Console.WriteLine();
        }
    }

    private static void DrawLine(bool[,] grid, int x0, int y0, int x1, int y1)
    {
        int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
        int dy = -Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
        int err = dx + dy;
        while (true)
        {
            if (x0 >= 0 && x0 < grid.GetLength(0) && y0 >= 0 && y0 < grid.GetLength(1))
                grid[x0, y0] = true;
            if (x0 == x1 && y0 == y1) break;
            int e2 = 2 * err;
            if (e2 >= dy) { err += dy; x0 += sx; }
            if (e2 <= dx) { err += dx; y0 += sy; }
        }
    }
}
