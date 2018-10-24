using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
	class Program
	{
		static void Main(string[] args)
		{
			int queriesNum = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < queriesNum; i++)
			{
				int[] query = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

				switch (query[0])
				{
					case 1:
						stack.Push(query[1]);
						break;

					case 2:
						stack.Pop();
						break;

					case 3:
						Console.WriteLine(stack.Max());
						break;
				}
			}
		}
	}
}
