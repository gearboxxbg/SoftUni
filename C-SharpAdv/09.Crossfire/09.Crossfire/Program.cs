using System;
using System.Collections.Generic;
using System.Linq;

    class Crossfire
    {
        static void Main()
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixSizes[0];
            int cols = matrixSizes[1];

            var mainList = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                var rowList = new List<int>();
                for (int y = 0; y < cols; y++)
                {
                    rowList.Add(i * cols + y + 1);
                }

                mainList.Add(rowList);
            }

            string command;
            while ((command = Console.ReadLine()) != "Nuke it from orbit")
            {
                int[] commandArgs = command.Split().Select(int.Parse).ToArray();
                int shotRow = commandArgs[0];
                int shotCol = commandArgs[1];
                int radius = commandArgs[2];

                for (int i = 0; i < mainList.Count; i++)
                {
                    for (int y = 0; y < mainList[i].Count; y++)
                    {
                        if ((i == shotRow && Math.Abs(y - shotCol) <= radius) ||
                            (y == shotCol && Math.Abs(i - shotRow) <= radius))
                        {
                            mainList[i][y] = 0;
                        }
                    }
                }

                for (int i = 0; i < mainList.Count; i++)
                {
                    mainList[i].RemoveAll(x => x == 0);
                    if (mainList[i].Count == 0)
                    {
                        mainList.RemoveAt(i);
                        i--;
                    }
                }
            }

            for (int i = 0; i < mainList.Count; i++)
            {
                Console.WriteLine(string.Join(" ", mainList[i]));
            }
        }
    }
