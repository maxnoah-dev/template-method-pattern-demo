namespace Lab03.Bai1_Beverage;

/// <summary>
/// Trà: Brew = ngâm túi trà, AddCondiments = thêm chanh.
/// </summary>
public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Ngâm túi trà trong nước sôi");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Thêm chanh");
    }
}
