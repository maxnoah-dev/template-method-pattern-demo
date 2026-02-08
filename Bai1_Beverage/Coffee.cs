namespace Lab03.Bai1_Beverage;

/// <summary>
/// Cà phê: Brew = pha cà phê, AddCondiments = thêm đường và sữa.
/// </summary>
public class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Pha cà phê với nước sôi");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Thêm đường và sữa");
    }
}
