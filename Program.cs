using Lab03.Bai1_Beverage;
using Lab03.Bai2_Triangle;
using Lab03.Bai3_DataExport;

// ========== BÀI 1: Pha chế thức uống (Template Method) ==========
Console.WriteLine("========== BÀI 1: Pha chế thức uống ==========\n");

Beverage tea = new Tea();
Console.WriteLine("--- Pha trà ---");
tea.PrepareBeverage();

Console.WriteLine();

Beverage coffee = new Coffee();
Console.WriteLine("--- Pha cà phê ---");
coffee.PrepareBeverage();

// ========== BÀI 2: Vẽ tam giác (Template Method) ==========
Console.WriteLine("\n========== BÀI 2: Vẽ tam giác ==========\n");

var a = new Point2D(2, 2);
var b = new Point2D(18, 2);
var c = new Point2D(10, 15); // điểm C sẽ được điều chỉnh tùy loại tam giác

Console.WriteLine("--- Tam giác thường ---");
var normal = new NormalTriangle(a, b, c);
normal.Draw();

Console.WriteLine("\n--- Tam giác vuông (góc tại A) ---");
var right = new RightTriangle(a, b, c);
right.Draw();

Console.WriteLine("\n--- Tam giác cân (AC = BC) ---");
var isosceles = new IsoscelesTriangle(a, b, c);
isosceles.Draw();

Console.WriteLine("\n--- Tam giác đều ---");
var equilateral = new EquilateralTriangle(a, b, c);
equilateral.Draw();

// ========== BÀI 3: Xuất dữ liệu (Template Method - đề xuất) ==========
Console.WriteLine("\n========== BÀI 3: Xuất dữ liệu (Template Method) ==========\n");

DataExporter csv = new CsvExporter();
csv.Export("output.csv");

Console.WriteLine();

DataExporter json = new JsonExporter();
json.Export("output.json");

Console.WriteLine("\nHoàn thành Lab 3 - Template Method.");
