using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance
{
	internal class Warrior:Player
	{
		public bool HasSword
		{
			get; private set;
		}
		public 	bool hasShield
		{
			get; private set;
		}
		public Warrior(string name) : base(name) {
			hasShield = true;
			HasSword = true;
		}
		public override void Attack(Player enemy)
		{
			if (HasSword)
			{
				Console.WriteLine("Swish-Swash!");
				enemy.Hp -= 2;
			}
			else
			{

				base.Attack(enemy);
			}
		
		}
		public  override string ToString()
		{
			return $"{base.ToString()} with Sword :{ HasSword} )" ;
		}

	}
}
