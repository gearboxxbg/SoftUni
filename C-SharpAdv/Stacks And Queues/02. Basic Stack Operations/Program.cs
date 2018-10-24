using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			//Commands
			int[] input = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			int numCount = input[0];
			int elementsToPop = input[1];
			int search = input[2];

			//Numbers
			int[] numbers = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < numCount; i++)
			{
				stack.Push(numbers[i]);
			}

			for (int i = 0; i < elementsToPop && stack.Count > 0; i++)
			{
				stack.Pop();
			}

			//result
			if (stack.Count == 0)
			{
				Console.WriteLine("0");
			}
			else if (stack.Contains(search))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine(stack.Min());
			}
		}
	}
}
