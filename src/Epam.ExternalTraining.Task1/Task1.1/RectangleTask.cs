using System;
using Epam.ExternalTraining.Abstractions;
using Epam.ExternalTraining.Abstractions.Task1_1;

namespace Epam.ExternalTraining.Task1.TheMagnificentTen
{
	public class RectangleTask : IRectangleTask
	{
		public void Run()
		{
			//throw new NotImplementedException(); // TODO: remove the task solution

			Console.Write("Enter your credit card number: ");

			if (!int.TryParse(Console.ReadLine(), out var a) || a <= 0
				|| !int.TryParse(Console.ReadLine(), out var b) || b <= 0)
			{
				Console.WriteLine("Number must be a positive number");
				return;
			}

			Console.WriteLine((a * b).ToString());
		}
	}
}
