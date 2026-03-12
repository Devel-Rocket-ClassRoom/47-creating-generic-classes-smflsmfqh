using System;
using System.Security.Cryptography;

Converter<string, int> StoIconverter = new Converter<string, int>((msg) => msg.Length);
Converter<int, string> ItoSconverter = new Converter<int, string>((num) => $"{num.ToString()}번");
Converter<double, int> DtoIconverter = new Converter<double, int>((num) => (int)num);

string[] strings = { "Hello", "World", "C#" };
int[] ints = { 1, 2, 3 };
double[] doubles = { 3.7, 1.2, 9.9 };

Console.WriteLine("=== 문자열 -> 길이 변환 ===");
Console.WriteLine($"{strings[0]} -> {StoIconverter.Convert(strings[0])}");
Console.WriteLine($"전체 변환: {string.Join(", ", StoIconverter.ConvertAll(strings))}");
Console.WriteLine();
Console.WriteLine("=== 정수 -> 문자열 변환 ===");
Console.WriteLine($"{ints[0]} -> {ItoSconverter.Convert(ints[0])}");
Console.WriteLine($"전체 변환: {string.Join(", ", ItoSconverter.ConvertAll(ints))}");
Console.WriteLine();
Console.WriteLine("=== 실수 -> 정수 변환 ===");
Console.WriteLine($"{doubles[0]} -> {DtoIconverter.Convert(doubles[0])}");
Console.WriteLine($"전체 변환: {string.Join(", ", DtoIconverter.ConvertAll(doubles))}");

