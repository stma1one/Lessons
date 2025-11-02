using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
	internal class HomeLander : SuperHero, ILaserble, IFlyble
	{
		public void Fly()
		{
			Console.WriteLine(	"I am Hero Flying") ;
		}

		public void ShootLaser()
		{
			Console.WriteLine("this is my homelander lazer");
		}
	}
}
