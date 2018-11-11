using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Predicate<int> dividable = x => x % 2 == 0;
				Predicate<int> notDividable2 = x => x % 2 != 0;

				List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
				List<int> evenNumbers = new List<int>();
				List<int> oddNumbers = new List<int>();


				foreach (int number in input)
				{
					if (dividable.Invoke(number))
					{
						oddNumbers.Add(number);
					}

					else if (notDividable2.Invoke(number))
					{
						evenNumbers.Add(number);
					}
				}

				oddNumbers.Sort();
				evenNumbers.Sort();

				foreach (int oddNumber in oddNumbers)
				{
					Console.Write(oddNumber + " ");
				}

				foreach (int evenNumber in evenNumbers)
				{
					Console.Write(evenNumber + " ");
				}
			}
			catch
			{
				Console.WriteLine("Error");
			}
		}
	}
}
