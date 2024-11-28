using FigureLib;
using FigureLib.Shapes;
using System.Reflection;

namespace FigureLibTests
{
	public class FigureTests
	{
		Assembly assemblyFigure = Assembly.GetAssembly(typeof(Shape));
		Dictionary<string, Shape> shapes = new Dictionary<string, Shape>
		{
			{"Circle", new Circle(1) },
			{"Triangle", new Triangle(3,4,5) }
		};
		Dictionary<string, double> shapesArea = new Dictionary<string, double>
		{
			{"Circle", 3.1415926535897931 },
			{"Triangle", 6 }
		};

		[Fact]
		//Проверка наследуют ли фигуры класс Shape
		public void FiguresInheritShapeClass()
		{
			var typesCount = assemblyFigure.GetTypes().
				Where(x => x.Namespace == "FigureLib.Shapes").
				Where(x => !x.Name.Contains("<>")).
				Count();
			var typesInheritShape = assemblyFigure.GetTypes().
				Where(x => x.Namespace == "FigureLib.Shapes").
				Where(x => x.BaseType.Name == "Shape").
				Count();
			Assert.Equal(typesCount, typesInheritShape);
		}

		[Theory]
		[InlineData("Circle")]
		[InlineData("Triangle")]
		//Проверка вычислений площади фигур
		public void CalculateArea(string shapeName)
		{
			Assert.Equal(shapesArea[shapeName], shapes[shapeName].CalculateArea());
		}

		[Theory]
		[InlineData("Circle", new object?[] {-1})]
		[InlineData("Triangle", new object?[] {-1,3,5})]
		//Проверка выдают ли ошибку при 
		public void FiguresNotExist(string shapeName, object?[] constructorParams)
		{
			var shapes = assemblyFigure.GetTypes().
				Where(x => x.Namespace == "FigureLib.Shapes").
				Where(x => !x.Name.Contains("<>"));
			var shape = shapes.Where(x => x.Name == shapeName).FirstOrDefault();
			var s = shape.GetConstructors().FirstOrDefault();
			var exception = Record.Exception(() => s.Invoke(constructorParams));
			Assert.NotNull(exception);
		}
	}
}