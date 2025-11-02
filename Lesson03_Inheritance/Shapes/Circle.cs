using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance.Shapes
{
	internal class Circle:Shape
	{
		private double radius;

		public double Radius
		{
			get
			{
				return radius;
			}
			set
			{
				if (value < 0) throw new ArgumentOutOfRangeException("radius cannot be negative");
				radius = value;
			}
		}
		public Circle(double radius) : base("Circle")
		{
			this.Radius = radius;
		}
		public override double CalculateArea()
		{
			return Math.PI * Radius * Radius;
		}
		public override double CalculatePerimater()
		{
			return 2*Math.PI*Radius;
		}
	}
}
