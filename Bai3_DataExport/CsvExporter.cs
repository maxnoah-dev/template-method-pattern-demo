namespace Lab03.Bai3_DataExport;

/// <summary>
/// Xuất dữ liệu ra file CSV (các trường cách nhau bằng dấu phẩy).
/// </summary>
public class CsvExporter : DataExporter
{
    protected override string TransformData(List<string> raw)
    {
        // Nhóm 3 cột: Tên, Tuổi, Lớp
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("Tên,Tuổi,Lớp");
        for (int i = 3; i < raw.Count; i += 3)
        {
            if (i + 2 < raw.Count)
                sb.AppendLine($"{raw[i]},{raw[i + 1]},{raw[i + 2]}");
        }
        return sb.ToString();
    }

    protected override void WriteToFile(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine($"[CSV] Đã ghi file: {path}");
    }
}
