using System;

namespace _07._Predicate_For_Names
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int nameLength = int.Parse(Console.ReadLine());
				Func<string, int, int> count = (string name, int n) => name.Length - n;
				string[] names = Console.ReadLine().Split(' ');

				foreach (string name in names)
				{
					if (count(name, nameLength) <= 0)
						Console.WriteLine(name);
				}
			}
			catch 
			{
				Console.WriteLine("error");
			}
		}
	}
}
