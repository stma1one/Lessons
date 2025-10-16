using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Inheritance
{
	internal class Wizard:Player
	{
		public int MagicLevel{ get; private set; }
		public Wizard(string name, int level) : base(name)
		{
			MagicLevel = level;
		}
		public void CastSpell()
		{
		}

	}
}
