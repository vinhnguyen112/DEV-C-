using System.Globalization;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

const decimal VatRate = 0.10m;        // hằng: thuế VAT 10%
var vn = new CultureInfo("vi-VN");    // var: kiểu suy luận là CultureInfo

// nhập dữ liệu
Console.Write("Tên sản phẩm: ");
string? tenSp = Console.ReadLine();

Console.Write("Đơn giá (VNĐ): ");
decimal donGia;
while (!decimal.TryParse(Console.ReadLine(), out donGia) || donGia <= 0)
    Console.Write("Giá trị không hợp lệ, nhập lại: ");

Console.Write("Số lượng: ");
int soLuong;
while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
    Console.Write("Giá trị không hợp lệ, nhập lại: ");

// tính toán
decimal thanhTien = donGia * soLuong;
decimal vat = thanhTien * VatRate;
decimal tongCong = thanhTien + vat;

// in hóa đơn
Console.WriteLine("\n===== HÓA ĐƠN =====");
Console.WriteLine($"Sản phẩm : {tenSp}");
Console.WriteLine(string.Format(vn, "Đơn giá : {0:N0} đ", donGia));
Console.WriteLine($"Số lượng : {soLuong}");
Console.WriteLine(string.Format(vn, "Thành tiền: {0:N0} đ", thanhTien));
Console.WriteLine(string.Format(vn, "VAT 10% : {0:N0} đ", vat));
Console.WriteLine(string.Format(vn, "Tổng cộng : {0:N0} đ", tongCong));