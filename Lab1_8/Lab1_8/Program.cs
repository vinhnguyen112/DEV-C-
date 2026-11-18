Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1. từ khóa field: thuộc tính tự cắt khoảng trắng khi gán
var khach = new Customer();
khach.Name = "  Nguyễn Văn An  ";
Console.WriteLine($"[{khach.Name}]");

// 2. extension members: thuộc tính và phương thức mở rộng cho string
Console.WriteLine("  ".IsBlank);
Console.WriteLine("Xin chào .NET 10".Truncate(8));

// 3. null-conditional assignment: chỉ gán khi đối tượng khác null
Customer? kh = null;
kh?.Name = "Bình";        // kh đang null: không làm gì, không báo lỗi
Console.WriteLine(kh is null ? "kh đang null" : kh.Name);

kh = new Customer();
kh?.Name = "  Lan  ";
kh?.Total += 100;
Console.WriteLine($"[{kh.Name}] - {kh.Total}");

public class Customer
{
    public string Name
    {
        get;
        set => field = value.Trim();    // field: trường ẩn của thuộc tính
    } = string.Empty;

    public decimal Total { get; set; }
}

public static class StringExtensions
{
    extension(string s)
    {
        public bool IsBlank => string.IsNullOrWhiteSpace(s);

        public string Truncate(int max) => s.Length <= max ? s : s[..max] + "...";
    }
}