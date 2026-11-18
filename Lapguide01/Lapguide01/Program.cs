namespace Lapguide01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập tên : ");
            String? name = Console.ReadLine();

            Console.WriteLine($"Xin chào {name}");
        }
    }
}