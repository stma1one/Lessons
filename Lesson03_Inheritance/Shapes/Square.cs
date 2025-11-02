using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance.Shapes
{
	internal class Square:Rectangle
	{
		public Square(double side) : base(side, side)
		{
			Name = "Square";
		}
	}
}
