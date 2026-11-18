Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1. toán tử số học và so sánh
int a = 17, b = 5;
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");
Console.WriteLine($"a * b = {a * b}");
Console.WriteLine($"a / b = {a / b}");
Console.WriteLine($"a % b = {a % b}");
Console.WriteLine($"((double)a / b = {(double)a / b}");
bool soSanh = a > b && b > 0;
Console.WriteLine($"a > b && b > 0 : {soSanh}");

// 2. độ ưu tiên
Console.WriteLine($"2 + 3 * 4   = {2 + 3 * 4}");
Console.WriteLine($"(2 + 3) * 4 = {(2 + 3) * 4}");
bool kq = true || false && false;    // && được tính trước ||
Console.WriteLine($"true || false && false = {kq}");

// 3. toán tử điều kiện ?: và gán kết hợp
double diem = 6.5;
string xepLoai = diem >= 5 ? "Đạt" : "Rớt";
Console.WriteLine($"Điểm {diem} => {xepLoai}");

int tong = 0;
tong += 10;
tong *= 3;
Console.WriteLine($"tong = {tong}");

// 4. tăng/giảm: hậu tố và tiền tố
int i = 5;
int x = i++;    // gán x = i (5) rồi mới tăng i
int y = ++i;    // tăng i rồi mới gán y
Console.WriteLine($"x = {x}, y = {y}, i = {i}");

// 5. is + pattern
int tuoi = 25;
bool nguoiLon = tuoi is >= 18 and < 65;
Console.WriteLine($"Tuổi {tuoi} là người lớn? {nguoiLon}");

object o = "xin chào";
if (o is string s && s.Length > 3)
    Console.WriteLine(s.ToUpper());

// 6. chỉ số từ cuối (^) và đoạn (..)
var ds = new[] { 10, 20, 30, 40, 50 };
string doan = string.Join(",", ds[1..3]);
Console.WriteLine($"Phần tử cuối: {ds[^1]}; đoạn [1..3]: {doan}");