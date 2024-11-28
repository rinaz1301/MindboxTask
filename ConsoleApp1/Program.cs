using FigureLib;
using FigureLib.Shapes;

var circle = new Circle(0);
var c = circle.CalculateArea();
Console.WriteLine(c);


Console.WriteLine();

var triangle = new Triangle(3,4,5);
var t = triangle.CalculateArea();
Console.WriteLine(t);
Console.WriteLine(triangle.IsRight());


Console.ReadKey();
