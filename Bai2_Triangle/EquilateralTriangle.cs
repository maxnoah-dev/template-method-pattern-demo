namespace Lab03.Bai2_Triangle;

/// <summary>
/// Tam giác đều: di chuyển C sao cho AB = BC = CA.
/// C là đỉnh thứ 3 của tam giác đều từ cạnh AB (phía trên trung trực).
/// </summary>
public class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(Point2D a, Point2D b, Point2D c) : base(a, b, c) { }

    protected override void AdjustThirdPoint()
    {
        var mid = new Point2D((A.X + B.X) / 2, (A.Y + B.Y) / 2);
        var ab = B - A;
        var perp = ab.Perpendicular();
        perp.Normalize();
        double side = ab.Length();
        double height = side * Math.Sqrt(3) / 2; // chiều cao tam giác đều
        C = mid + height * perp;
    }
}
