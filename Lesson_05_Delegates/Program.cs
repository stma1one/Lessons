namespace Lesson_05_Delegates
{
	public delegate bool ValidateRule(int num);
	public delegate void PrintMessage(string m);
	internal class Program
	{

		public static List<int> FilterByCondition(List<int> lst, ValidateRule r)
		{
			List<int> result = new List<int>();
			foreach (int i in lst)
			{
				if(r(i))
					result.Add(i);
			}
			return result;
		}

		public static bool IsEven(int n)
		{
			return n % 2 == 0;
		}
		public static List<int> OnlyEven(List<int> lst)
		{
			List<int> result = new List<int>();
			foreach(var i in lst)
							{
				if(IsEven(i))
					result.Add(i);
			}
			return result;
		}

		public static bool IsBiggerThan5(int n)
		{
			return n > 5;
		}
		public static List<int> BiggerThan5(List<int> lst)
		{
			List<int> result = new List<int>();
			foreach (var i in lst)
			{
				if (IsBiggerThan5(i) )
					result.Add(i);
			}
			return result;
		}

		public static void MyMessage(string m)
		{
			Console.WriteLine(m);
		}
			static void Main(string[] args)
		{
			PrintMessage msg = MyMessage;
			msg("Go Home");
			List<int> ls=[5,12,3,27,2];
			ValidateRule valid = IsEven;
		
			var result= FilterByCondition(ls, valid);
			foreach(var i in result)
			{
				Console.WriteLine(i);
			}
			//valid = IsBiggerThan5;
		    result = FilterByCondition(ls, IsBiggerThan5);
			foreach (var i in result)
			{
				Console.WriteLine(i);
			}


		}
	}
}
