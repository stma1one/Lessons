namespace Lesson03_Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Warrior w = new Warrior("Kai");

			Wizard arnon= new Wizard("Arnon");
			int spellPower = 3;
			arnon.SpellPower = spellPower;

			arnon.Attack(w);

			Player pl = new Player("Zwilli");
			Console.WriteLine(arnon);
			Console.WriteLine(w);

			Player[] players = new Player[3];
			players[0] = new Wizard("Gal");
			players[1] = new Warrior("Yarden");
			players[2] = pl;

			for (int i = 0; i < players.Length; i++)
			{
				players[i].Attack(w);

				if (players[i] is Wizard)
					((Wizard)players[i]).CastSpell(w);
				
			}

		}
	}
}
