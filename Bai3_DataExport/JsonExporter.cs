namespace Lab03.Bai3_DataExport;

/// <summary>
/// Xuất dữ liệu ra file JSON.
/// </summary>
public class JsonExporter : DataExporter
{
    protected override string TransformData(List<string> raw)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("{ \"items\": [");
        bool first = true;
        for (int i = 3; i < raw.Count; i += 3)
        {
            if (i + 2 >= raw.Count) break;
            if (!first) sb.AppendLine(",");
            sb.Append($"  {{ \"Tên\": \"{raw[i]}\", \"Tuổi\": \"{raw[i + 1]}\", \"Lớp\": \"{raw[i + 2]}\" }}");
            first = false;
        }
        sb.AppendLine();
        sb.AppendLine("]}");
        return sb.ToString();
    }

    protected override void WriteToFile(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine($"[JSON] Đã ghi file: {path}");
    }
}
