namespace Lab03.Bai2_Triangle;

/// <summary>
/// Điểm trong không gian 2 chiều.
/// </summary>
public struct Point2D
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Point2D operator +(Point2D a, Point2D b) => new(a.X + b.X, a.Y + b.Y);
    public static Point2D operator -(Point2D a, Point2D b) => new(a.X - b.X, a.Y - b.Y);
    public static Point2D operator *(double k, Point2D p) => new(k * p.X, k * p.Y);

    public double Length() => Math.Sqrt(X * X + Y * Y);

    /// <summary>
    /// Vector vuông góc với (this), cùng độ dài: (-Y, X).
    /// </summary>
    public Point2D Perpendicular() => new(-Y, X);

    public void Normalize()
    {
        var len = Length();
        if (len > 1e-10) { X /= len; Y /= len; }
    }
}
