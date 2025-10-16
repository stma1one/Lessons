namespace Lesson03_Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Warrior w1 = new Warrior("Agam");
			Console.WriteLine(w1.Name);
			Warrior w2 = new Warrior("Liya");
			Wizard wiz = new Wizard("yotam", 10);
			Player[] players = new Player[3];
			players[0] = w1;
			players[1] = wiz;
			players[2] = w2;
			w2.HasSword = true;

			for (int i = 0; i < players.Length; i++)
			{
				Console.WriteLine(players[i].Name
					+ "Hp:" + players[i].Hp);
				if (players[i] is Warrior w){
					//Warrior w = (Warrior)players[i];
					//Console.WriteLine(((Warrior)players[i]).HasSword);
					Console.WriteLine(w.HasSword);
							}
				players[i].Attack(w2);
			}

		}
	}
}
