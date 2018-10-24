using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Basic_Queue_Operations
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
			int enqueueNum = input[0];
			int dequeueNum = input[1];
			int search = input[2];

			//Numbers
			int[] numbers = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();
			Queue<int> queue = new Queue<int>();

			for (int i = 0; i < enqueueNum; i++)
			{
				queue.Enqueue(numbers[i]);
			}

			for (int i = 0; i < dequeueNum; i++)
			{
				queue.Dequeue();
			}

			//results
			if (queue.Count == 0)
			{
				Console.WriteLine("0");
			}
			else if (queue.Contains(search))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine(queue.Min());
			}
		}
	}
}
