# Lab 3 – Template Method

Bài tập Lab 3 môn Design Pattern: cài đặt các bài toán sử dụng **Template Method**.

## Yêu cầu môi trường

- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 trở lên (khuyến nghị .NET 10)

## Cấu trúc project

```
521H0476_Lab03/
├── Bai1_Beverage/          # Bài 1: Pha chế thức uống (trà, cà phê)
│   ├── Beverage.cs         # Lớp trừu tượng, template method PrepareBeverage()
│   ├── Tea.cs
│   └── Coffee.cs
├── Bai2_Triangle/          # Bài 2: Vẽ tam giác (thường, vuông, cân, đều)
│   ├── Triangle.cs        # Template method Draw(), hook AdjustThirdPoint()
│   ├── Point2D.cs
│   ├── NormalTriangle.cs
│   ├── RightTriangle.cs
│   ├── IsoscelesTriangle.cs
│   └── EquilateralTriangle.cs
├── Bai3_DataExport/        # Bài 3: Xuất dữ liệu (CSV, JSON)
│   ├── DataExporter.cs    # Template method Export()
│   ├── CsvExporter.cs
│   └── JsonExporter.cs
├── Program.cs              # Điểm vào, chạy demo cả 3 bài
├── 521H0476_Lab03.csproj
└── README.md
```

## Build & chạy

```bash
dotnet restore
dotnet build
dotnet run
```

## Nội dung từng bài

### Bài 1 – Pha chế thức uống

- **Template method:** `PrepareBeverage()` (đun nước → pha → rót cốc → thêm gia vị).
- **Primitive operations:** `Brew()`, `AddCondiments()` do lớp con cài đặt.
- **Lớp con:** `Tea` (ngâm trà, thêm chanh), `Coffee` (pha cà phê, thêm đường và sữa).

### Bài 2 – Vẽ tam giác

- **Template method:** `Draw()`: gọi **hook** `AdjustThirdPoint()` (di chuyển điểm C) rồi vẽ ra console bằng dấu `*`.
- **Hook:** `AdjustThirdPoint()` — tam giác thường không đổi; vuông/cân/đều điều chỉnh C để đúng tính chất hình học.
- **Lớp con:** `NormalTriangle`, `RightTriangle`, `IsoscelesTriangle`, `EquilateralTriangle`.

### Bài 3 – Xuất dữ liệu (đề xuất)

- **Template method:** `Export(path)`: mở nguồn → đọc dữ liệu → chuyển đổi → ghi file → đóng nguồn.
- **Primitive/hook:** `ReadData()`, `TransformData()`, `WriteToFile()`.
- **Lớp con:** `CsvExporter`, `JsonExporter` (format và cách ghi file khác nhau).

## Design pattern sử dụng

**Template Method:** Định nghĩa skeleton của thuật toán trong lớp cơ sở, các bước cụ thể (primitive operations) hoặc tùy biến (hooks) do lớp con triển khai, không đổi thứ tự bước.
