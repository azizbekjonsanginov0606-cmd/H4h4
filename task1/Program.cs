// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task1;
Cache<int>.Add(10);
int value = Cache<int>.GetValue(10);
Cache<int>.RemoveValue(10);
int valueg = Cache<int>.GetValue(value);
Console.WriteLine(valueg);
Cache<string>.Add("Hello");
var value1 = Cache<string>.GetValue("Hello");
Console.WriteLine(value1);
