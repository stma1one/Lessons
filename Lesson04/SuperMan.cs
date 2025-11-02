using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
	internal class SuperMan : SuperHero, IFlyble,ILaserble
	{
		public void ShootLaser()
		{
			Console.WriteLine("Lassssssser");
		}

		public void Fly()
		{
			Console.WriteLine("It's a bird? it's a plane? no it's SuperMan");
		}
	}
}
