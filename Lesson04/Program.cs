namespace Lesson04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IFlyble[] flybles = new IFlyble[2];
			flybles[0] = new SuperMan();
			flybles[1] = new Boeing747();
			for (int i = 0; i < flybles.Length; i++)
			{
				flybles[i].Fly();
				if (flybles[i] is SuperMan super)
				{
					//SuperMan super = (SuperMan)flybles[i];
					super.ShootLaser();
					//((SuperMan)flybles[i]).ShootLaser();
				}
			}
			ILaserble[] laserShooters= new ILaserble[3];
			laserShooters[0]=(SuperMan) flybles[0];
			laserShooters[1]=new DarthVader();
			laserShooters[2] = new HomeLander();
		
			
			
			
			for (int i = 0; i < laserShooters.Length; i++)
			{
				laserShooters[i].ShootLaser();
				if (laserShooters[i] is IFlyble fly)
					fly.Fly();


			}
		}
	}
}
