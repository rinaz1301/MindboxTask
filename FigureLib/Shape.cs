namespace FigureLib
{
	public abstract class Shape
	{
		protected abstract double? Area { get; set; }
		public abstract double CalculateArea();
	}
}