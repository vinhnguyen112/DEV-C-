Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1. nullable
int? soLuong = null;       // nullable value type
string? ghiChu = null;     // nullable reference type
string ten = "An";         // không được phép null

int n = soLuong ?? 0;             // lấy 0 nếu soLuong là null
int len = ghiChu?.Length ?? 0;    // ?. an toàn với null
ghiChu ??= "Không có";            // chỉ gán khi ghiChu đang null
Console.WriteLine($"n = {n}, len = {len}, ghiChu = {ghiChu}");
if (ten is not null)
    Console.WriteLine(ten.ToUpper());

// 2. boxing và unboxing
int num = 42;
object boxed = num;       // boxing: sao chép lên heap
int back = (int)boxed;    // unboxing: phải ép đúng kiểu gốc
Console.WriteLine($"num = {num}, boxed = {boxed}, back = {back}");

try
{
    long sai = (long)boxed;   // sai: kiểu gốc là int
    Console.WriteLine(sai);
}
catch (InvalidCastException ex)
{
    Console.WriteLine($"Lỗi: {ex.GetType().Name}");
}

long dung = (int)boxed;       // đúng: unbox về int rồi mới mở rộng sang long
Console.WriteLine($"Ép đúng cách: {dung}");

// 3. giá trị mặc định
int d1 = default;
bool d2 = default;
string? d3 = default;
string d3Text = d3 ?? "null";
string d4 = default(DateTime).ToString("yyyy-MM-dd");
Console.WriteLine($"{d1} | {d2} | {d3Text} | {d4}");