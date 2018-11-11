using System;
using System.Linq;

namespace _09._List_Of_Predicates
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Func<int, int, int> dividable = (int x, int y) => x % y;
				int limit = int.Parse(Console.ReadLine());
				int[] numbers = Console.ReadLine()
					.Split(' ')
					.Select(int.Parse)
					.ToArray();

				for (int i = 1; i <= limit; i++)
				{
					int count = 0;
					for (int j = 0; j < numbers.Length; j++)
					{
						int number = numbers[j];
						if (dividable(i, number) == 0)
						{
							count++;
						}
					}

					if (count == numbers.Length) Console.Write(i + " ");
				}
			}
			catch
			{
				Console.WriteLine("Error");
			}
		}
	}
}
