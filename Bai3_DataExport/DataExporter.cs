namespace Lab03.Bai3_DataExport;

/// <summary>
/// Bài 3 - Đề xuất: Bài toán xuất dữ liệu (Template Method).
/// Quy trình chung: Mở nguồn -> Đọc dữ liệu -> Chuyển đổi -> Ghi file -> Đóng nguồn.
/// Các lớp con định nghĩa format (CSV, JSON).
/// </summary>
public abstract class DataExporter
{
    /// <summary>
    /// Template Method: skeleton của quy trình xuất dữ liệu.
    /// </summary>
    public void Export(string outputPath)
    {
        OpenSource();
        var raw = ReadData();
        var transformed = TransformData(raw);
        WriteToFile(outputPath, transformed);
        CloseSource();
    }

    private void OpenSource()
    {
        Console.WriteLine("[Exporter] Mở nguồn dữ liệu...");
    }

    /// <summary>
    /// Đọc dữ liệu thô - primitive operation (có thể khác nhau theo nguồn).
    /// Ở đây dùng dữ liệu mẫu cố định.
    /// </summary>
    protected virtual List<string> ReadData()
    {
        return new List<string> { "Tên", "Tuổi", "Lớp", "Nguyễn A", "20", "K52", "Trần B", "21", "K51" };
    }

    /// <summary>
    /// Chuyển đổi dữ liệu sang format chuẩn bị ghi - hook (có thể override).
    /// </summary>
    protected virtual string TransformData(List<string> raw)
    {
        return string.Join(", ", raw);
    }

    /// <summary>
    /// Ghi nội dung ra file - primitive operation (CSV vs JSON khác nhau).
    /// </summary>
    protected abstract void WriteToFile(string path, string content);

    private void CloseSource()
    {
        Console.WriteLine("[Exporter] Đóng nguồn dữ liệu.");
    }
}
