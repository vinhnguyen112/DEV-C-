#:package Humanizer@2.14.1

using Humanizer;

Console.WriteLine("hello world".Titleize());
Console.WriteLine(DateTime.Now.AddHours(-3).Humanize());
dotnet run hello.cs