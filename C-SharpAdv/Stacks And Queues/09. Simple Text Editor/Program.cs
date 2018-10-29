using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _09._Simple_Text_Editor
{
	class Program
	{
		static void Main(string[] args)
		{
			int commandsNum = int.Parse(Console.ReadLine());
			string text = string.Empty;
			Stack<string> saved = new Stack<string>();

			for (int i = 0; i < commandsNum; i++)
			{
				string[] command = Console.ReadLine().Split();
				int commandType = int.Parse(command[0]);

				switch (commandType)
				{
					case 1:
						saved.Push(text);
						string textToAdd = command[1];
						text += textToAdd;
						break;
					case 2:
						saved.Push(text);
						int removeIndexes = int.Parse(command[1]);
						text = text.Remove(text.Length - removeIndexes,removeIndexes);
						break;
					case 3:
						int index = int.Parse(command[1]);
						Console.WriteLine(text[index - 1]);
						break;
					case 4:
						text = String.Empty;
						text = saved.Pop();
						break;
				}
			}
		}
	}
}
