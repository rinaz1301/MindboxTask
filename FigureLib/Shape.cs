namespace FigureLib
{
	public abstract class Shape
	{
		public abstract double? Area { get; protected set; }
		public abstract double CalculateArea();
	}
}