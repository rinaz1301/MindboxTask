using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib.Shapes
{
	public class Triangle : Shape
	{
		private readonly double[] _sides = new double[3];

		public override double? Area { get; protected set; }
		public Triangle(double side1, double side2, double side3)
		{
			if (NotExist(side1, side2, side3)) 
				throw new ArgumentException("Triangle with these sides can not exist.");
			if (side1 < 0 || side2 < 0 || side3 < 0) 
				throw new ArgumentException("Side can not be negative.");
			_sides[0] = side1;
			_sides[1] = side2;
			_sides[2] = side3;
		}
		public override double CalculateArea()
		{
			if(Area == null)
			{
				double halfPer = (_sides[0]+_sides[1]+_sides[2]) / 2;
				Area = Math.Sqrt(halfPer * (halfPer - _sides[0]) * (halfPer - _sides[1]) * (halfPer - _sides[2]));
			}
			return (double)Area;
		}
		public bool IsRight()
		{
			var orderedSides = _sides.OrderBy(x=> x);
			if (orderedSides.Take(2).Sum(x => x * x) == orderedSides.TakeLast(1).Sum(x => x * x))
				return true;
			return false;
		}
		private bool NotExist(double side1, double side2, double side3)
		{
			if (side1 + side2 <= side3) return true;
			if (side1 + side3 <= side2) return true;
			if (side2 + side3 <= side1) return true;
			return false;
		}
	}
}
