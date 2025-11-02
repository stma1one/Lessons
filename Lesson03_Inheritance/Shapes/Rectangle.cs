using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance.Shapes
{
	internal class Rectangle : Shape
	{
		private double width;
		private double height;

		public double Width
		{
			get
			{
				return width;
			}
			set
			{
				if (value < 0) throw new ArgumentOutOfRangeException("width cannot be negative");
				width = value;
			}
		}
		public double Height
		{
			get
			{
				return height;
			}
			set
			{
				if (value < 0) throw new ArgumentOutOfRangeException("width cannot be negative");
				height = value;
			}
		}
		public Rectangle(double w, double h) : base("Rectangle")
		{
			Width = w;
			Height = h;
		}

		public override double CalculateArea()
		{
			return Width * Height;
		}
		public override double CalculatePerimater()
		{
			return 2 * (Width + Height);
		}
	}
}
