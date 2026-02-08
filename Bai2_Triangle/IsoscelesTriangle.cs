namespace Lab03.Bai2_Triangle;

/// <summary>
/// Tam giác cân: di chuyển C sao cho AC = BC (C nằm trên trung trực của AB).
/// </summary>
public class IsoscelesTriangle : Triangle
{
    public IsoscelesTriangle(Point2D a, Point2D b, Point2D c) : base(a, b, c) { }

    protected override void AdjustThirdPoint()
    {
        var mid = new Point2D((A.X + B.X) / 2, (A.Y + B.Y) / 2);
        var ab = B - A;
        var perp = ab.Perpendicular();
        perp.Normalize();
        double height = ab.Length() * 0.8; // chiều cao tùy chọn
        C = mid + height * perp;
    }
}
