using Lesson03_Inheritance.Warriors;
using System.Net.Http.Headers;

namespace Lesson03_Inheritance.Shapes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IFlyble[] flyers = new IFlyble[2];
			flyers[0] = new Plane();
			flyers[1] = new SuperMan();

			for (int i = 0; i < flyers.Length; i++)
			{
				if (flyers[i] is Plane p)
				{
					p.Model = "BoingBoing";
					Console.WriteLine(p.Model);
				}
				
					flyers[i].Fly();

			}

			Shape[] shapes = new Shape[4];
			shapes[0] = new Circle(5);
			shapes[1] = new Rectangle(3, 4);
			shapes[2] = new Square(3);
			shapes[3] = new Circle(4.3);
			//shapes[4] = new Shape("Shape");
			for (int i = 0; i < shapes.Length; i++)
			{
				Console.WriteLine($"{shapes[i].Name}: {shapes[i].CalculatePerimater()} , {shapes[i].CalculateArea()}");
				if (shapes[i] is Circle c)
				{
					Console.WriteLine( c.Radius);
				}
				if (shapes[i] is Rectangle)
				{
					Rectangle r = (Rectangle) shapes[i];
					Console.WriteLine(r.Width);
				}
			}

		}
	}
}
