using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance
{
	internal class Plane:IFlyble
	{
		public string Model
		{
			get; set;
		}

		public void Fly()
		{
			Console.WriteLine("this is your Captain Speaking");
		}
	}
}
