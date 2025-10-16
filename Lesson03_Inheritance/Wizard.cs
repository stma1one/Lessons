using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance
{
	internal class Wizard: Player
	{
		private int spellPower;
		public int SpellPower
		{
			get { return spellPower; }
			set {
				if(value < 0||value>10)
				{
					throw new ArgumentOutOfRangeException("SpellPower must be non-negative");
				}
				
				spellPower = value; }
		}
		public  void CastSpell(Player other)
		{
			Console.WriteLine("Abracadabra!");
			other.Strength -= SpellPower;
		}

		public Wizard(string name): base(name)
		{
			SpellPower = 1;
		}

		public override void Attack(Player enemy)
		{
			Console.WriteLine("Fireball!");
			CastSpell(enemy);
		}
		
	}
}
