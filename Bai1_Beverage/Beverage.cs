namespace Lab03.Bai1_Beverage;

/// <summary>
/// Lớp trừu tượng định nghĩa Template Method cho quy trình pha chế thức uống.
/// PrepareBeverage() là template method; các bước cụ thể do lớp con cài đặt.
/// </summary>
public abstract class Beverage
{
    /// <summary>
    /// Template Method: định nghĩa skeleton của thuật toán pha chế.
    /// </summary>
    public void PrepareBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Đun sôi nước");
    }

    /// <summary>
    /// Ngâm/pha nguyên liệu (trà, cà phê) - primitive operation.
    /// </summary>
    protected abstract void Brew();

    private void PourInCup()
    {
        Console.WriteLine("Rót vào cốc");
    }

    /// <summary>
    /// Thêm gia vị (chanh, sữa, đường...) - primitive operation.
    /// </summary>
    protected abstract void AddCondiments();
}
