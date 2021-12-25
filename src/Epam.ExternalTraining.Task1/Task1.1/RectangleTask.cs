using System;
using Epam.ExternalTraining.Abstractions;
using Epam.ExternalTraining.Abstractions.Task1_1;

namespace Epam.ExternalTraining.Task1.TheMagnificentTen
{
	public class RectangleTask : IRectangleTask
	{
		public void Run(IConsole console)
		{
			//throw new NotImplementedException(); // TODO: remove the task solution

			if (!int.TryParse(console.ReadLine(), out var a) || a <= 0
				|| !int.TryParse(console.ReadLine(), out var b) || b <= 0)
			{ 
				console.WriteLine("Number must be a positive number");
				return;
			}

			console.WriteLine((a * b).ToString());
		}
	}
}
