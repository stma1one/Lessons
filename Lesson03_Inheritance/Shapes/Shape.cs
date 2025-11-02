using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance.Shapes
{
	internal abstract class Shape
	{
		public string Name { get; set; }
	public Shape(string name)
		{
			Name = name;
		}
		public abstract double CalculateArea();
		public abstract double CalculatePerimater();
	}
}
