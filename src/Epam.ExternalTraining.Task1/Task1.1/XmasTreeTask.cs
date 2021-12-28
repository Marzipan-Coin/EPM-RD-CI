using Epam.ExternalTraining.Abstractions.Task1_1;
using System;

namespace Epam.ExternalTraining.Task1.TheMagnificentTen
{
	public class XmasTreeTask : IXmasTreeTask
	{
		public void Run()
		{
			//throw new NotImplementedException(); // TODO: remove the task solution
			Console.Write("Enter your credit card number: ");
			if (!int.TryParse(Console.ReadLine(), out var h) || h <= 0)
			{
				Console.WriteLine("Number must be a positive number");
				return;
			}

			// Solution 1 
			for (int triNum = 1; triNum <= h; triNum++)
			for (int triLine = 0; triLine < triNum; triLine++)
			{
				Console.WriteLine(new string(' ', (h - triNum) + (h - triLine - 1)) + new string('*', 1 + triLine * 2));
			}
		}
	}
}
