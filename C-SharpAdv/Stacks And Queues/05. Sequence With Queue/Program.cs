using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Sequence_With_Queue
{
	class Program
	{
		static void Main(string[] args)
		{
			long currentElement = long.Parse(Console.ReadLine());
			Queue<long> sequence = new Queue<long>();
			Console.Write("{0} ", currentElement);
			sequence.Enqueue(currentElement);
			int count = 1;

			while (count < 50)
			{
				currentElement = sequence.Dequeue();
				Console.Write("{0} ", currentElement + 1);
				sequence.Enqueue(currentElement + 1);
				count++;
				if (count < 50)
				{
					Console.Write("{0} ", 2 * currentElement + 1);
					sequence.Enqueue(2 * currentElement + 1);
					count++;
				}
				else break;
				if (count < 50)
				{
					Console.Write("{0} ", currentElement + 2);
					sequence.Enqueue(currentElement + 2);
					count++;
				}
				else break;
			}
		}
	}
}

