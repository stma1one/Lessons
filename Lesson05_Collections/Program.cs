using System.ComponentModel;
using System.IO.IsolatedStorage;

namespace Lesson05_Collections
{
	internal class Program:object
	{
		static void Main(string[] args)
		{
			var x=new Queue<int>();
			var y = 5;
			var r = "Tal";
			List<int> ls = new List<int>();
			ls.Add(6);
			ls.Add(9);
			ls.Add(27);
			Console.WriteLine(ls[2]);
			Console.WriteLine(ls[0]+5);
			ls[1] = ls[0] + 5;
			foreach(var i in ls)
				Console.WriteLine(i);

			Console.WriteLine(ls.Count);
			ls.Remove(1);
			ls.Contains(1);
			Console.WriteLine(ls.Count);

			Dictionary<int, string> codes = new Dictionary<int, string>();
		codes.Add(44, "England");
			codes.Add(44, "Uganda");

			string country = codes[44];

			Dictionary<string, string> colors;

		}


	}
}
