using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance.Warriors
{
	internal class Warrior:Player
	{
		public bool HasSword
		{
			get;  set;
		}

		public Warrior(string name) : base(name)
		{
			HasSword = false;
			Strength += 100;	
		}

		public override void Attack(Player p2)
		{
			Console.WriteLine("Yoooooo hoooo");
			if (HasSword)
				p2.Hp -= Strength * 2;
			else
				base.Attack(p2);
		}

	}
}
