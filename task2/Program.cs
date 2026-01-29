// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task2;
double circleArea = Geometry.CalcCircleArea(5);
double circlePerimeter = Geometry.CalcCirclePerimeter(5);

double rectArea = Geometry.CalcRectangleArea(4, 6);
double rectPerimeter = Geometry.CalcRectanglePerimeter(4, 6);

double triArea = Geometry.CalcTriangleArea(3, 4);
double triPerimeter = Geometry.CalcTrianglePerimeter(3, 4, 5);
Console.WriteLine("Circle-Доира :");
Console.WriteLine($"Circle Area : {circleArea}");
Console.WriteLine($"Circle Perimeter : {circlePerimeter}");
Console.WriteLine("Rectangle-Росткунҷа :");
Console.WriteLine($"Rectangle Area : {rectArea}");
Console.WriteLine($"Rectangle Perimeter : {rectPerimeter}");
Console.WriteLine("Triangle-Секунҷа росткунҷа :");
Console.WriteLine($"Triangle Area : {triArea}");
Console.WriteLine($"Triangle Perimeter : {triPerimeter}");