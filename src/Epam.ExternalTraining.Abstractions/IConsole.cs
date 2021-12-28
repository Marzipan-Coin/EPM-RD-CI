using System.Collections.Generic;
using System.Text;

namespace Epam.ExternalTraining.Abstractions
{
	public interface IConsole
	{
		string ReadLine();

		void Write(string output);

		void WriteLine();
		void WriteLine(string output);
	}
}
