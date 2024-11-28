using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Shapes
{
	public class Circle : Shape
	{
		private readonly double _radius;
		public override double? Area { get; protected set; }
		public Circle(double radius)
		{
			if (radius < 0) throw new ArgumentException("Radius can not be negative");
			_radius = radius;
		}
		public override double CalculateArea()
		{
			if (Area == null) Area = Math.PI * _radius * _radius;
			return (double)Area;
		}
	}
}
