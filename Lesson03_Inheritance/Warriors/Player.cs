using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance.Warriors
{
	internal class Player
	{
		public string Name { get; init; }
		public int Hp {get;  set; }
		public int Strength { get; protected set; }

		public Player(string name)
		{
			Name = name;
			Hp = 1000;	
			Strength= 100	;
		}
		public virtual  void Attack(Player p2)
		{
			Console.WriteLine("Heee-Yaaa");
			p2.Hp -=Strength;
		}
	

	}
}
