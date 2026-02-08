namespace Lab03.Bai2_Triangle;

/// <summary>
/// Tam giác vuông: di chuyển C sao cho góc tại A = 90° (AB vuông góc AC).
/// C nằm trên đường qua A vuông góc với AB.
/// </summary>
public class RightTriangle : Triangle
{
    public RightTriangle(Point2D a, Point2D b, Point2D c) : base(a, b, c) { }

    protected override void AdjustThirdPoint()
    {
        var ab = B - A;
        var perp = ab.Perpendicular();
        perp.Normalize();
        double len = ab.Length();
        C = A + len * perp; // C cách A một đoạn = AB, tạo góc vuông tại A
    }
}
