﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._TriFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int targetCharactersSum = int.Parse(Console.ReadLine());
				string[] names = Console.ReadLine().Split(' ');

				Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray()
					.Select(ch => (int)ch).Sum() >= num;

				Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr
					.FirstOrDefault(str => func(str, num));

				string result = firstValidName(names, targetCharactersSum, isValidWord);
				Console.WriteLine(result);
			}
			catch
			{
				Console.WriteLine("Error");
			}
		}
	}
}
