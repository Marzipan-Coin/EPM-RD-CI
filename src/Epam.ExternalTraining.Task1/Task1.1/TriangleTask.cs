using Epam.ExternalTraining.Abstractions;
using Epam.ExternalTraining.Abstractions.Task1_1;

namespace Epam.ExternalTraining.Task1.TheMagnificentTen
{
	public class TriangleTask : ITriangleTask
	{
		public void Run(IConsole console)
		{
			//throw new NotImplementedException(); // TODO: remove the task solution

			if (!int.TryParse(console.ReadLine(), out var h) || h <= 0)
			{
				console.WriteLine("Number must be a positive number");
				return;
			}

			// Solution 1 
			//for (int i = 1; i <= h; i++)
			//	console.WriteLine(new string('*', i));

			// Solution 2
			//for (int i = 1; i <= h; i++)
			//{
			//	for (int width = 0; width < i; width++)
			//	{
			//		console.Write("*");
			//	}
			//	console.WriteLine();
			//}

			// Solution 3 (char)
			for (int i = 1; i <= h; i++)
			{
				for (int width = 0; width < i; width++)
				{
					console.Write("*");
				}
				console.WriteLine();
			}
		}
	}

}
