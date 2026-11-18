Console.OutputEncoding = System.Text.Encoding.UTF8;

// khai báo các biến thuộc những kiểu thường dùng
int tuoi = 20;
long dan = 1_400_000_000L;
double pi = 3.14159;
decimal gia = 19.99m;
bool ok = true;
char c = 'A';
byte b = 255;
short s = -32000;
float f = 3.14f;

// in bảng kiểu - kích thước (byte) - giá trị
Console.WriteLine("{0,-10}{1,-8}{2}", "Kiểu", "Byte", "Giá trị");
Dong("int", sizeof(int), tuoi);
Dong("long", sizeof(long), dan);
Dong("double", sizeof(double), pi);
Dong("decimal", sizeof(decimal), gia);
Dong("bool", sizeof(bool), ok);
Dong("char", sizeof(char), c);
Dong("byte", sizeof(byte), b);
Dong("short", sizeof(short), s);
Dong("float", sizeof(float), f);

// phạm vi giá trị
Console.WriteLine();
Console.WriteLine($"byte  : {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int   : {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long  : {long.MinValue} .. {long.MaxValue}");

// phép chia số nguyên và số thực
Console.WriteLine();
Console.WriteLine($"7 / 2  = {7 / 2}");
Console.WriteLine($"7 % 2  = {7 % 2}");
Console.WriteLine($"7 / 2.0 = {7 / 2.0}");

// double và decimal
double x = 0.1, y = 0.2;
decimal m = 0.1m, n = 0.2m;
Console.WriteLine();
Console.WriteLine($"double : 0.1 + 0.2 = {x + y}, bằng 0.3? {x + y == 0.3}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {m + n}, bằng 0.3? {m + n == 0.3}");

// tràn số (mặc định không báo lỗi)
int max = int.MaxValue;
max++;
Console.WriteLine($"int.MaxValue + 1 = {max}");

// hàm cục bộ dùng để in một dòng của bảng
static void Dong(string kieu, int size, object giaTri) =>
    Console.WriteLine("{0,-10}{1,-8}{2}", kieu, size, giaTri);
