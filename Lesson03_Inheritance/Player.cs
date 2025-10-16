using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance
{
	internal class Player
	{
		public string Name { get; set; }
		public int Hp {get; set; }
		public int Strength { get; set; }

		public Player(string name)
		{
			this.Name = name;
			Hp = 10;	
			Strength= 100	;
		}
		public virtual void Attack(Player p2)
		{
			Console.WriteLine("Heee-Yaaa");
			p2.Hp -= 1;
		}
		public override string ToString()
		{
			return $"{Name} (Hp={Hp}, Strength={Strength})";
		}

	}
}
