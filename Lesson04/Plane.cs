using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
	internal abstract class Plane : IFlyble
	{
		public string Name
		{
			get; set;
		}

		public abstract void Fly();
	}
}
