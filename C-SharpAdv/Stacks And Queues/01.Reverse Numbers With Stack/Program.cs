using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Reverse_Numbers_With_Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			Stack<int> numberReverser = new Stack<int>(input);

			Console.WriteLine(string.Join(" ", numberReverser));
		}
	}
}
