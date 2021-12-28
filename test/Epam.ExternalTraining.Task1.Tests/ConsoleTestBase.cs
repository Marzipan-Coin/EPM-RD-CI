using System;
using System.IO;
using System.Text;

namespace Epam.ExternalTraining.Task1.Tests
{
	public abstract class ConsoleTestBase : IDisposable
	{
		private bool _isDisposed;
		private StringWriter _textWriter;


		protected static void SetConsoleInput(params string[] inputLines)
		{
			var input = new StringReader(string.Join(Environment.NewLine, inputLines));
			Console.SetIn(input);
		}

		protected StringBuilder BindConsoleOutput()
		{
			_textWriter = new StringWriter();
			Console.SetOut(_textWriter);

			return _textWriter.GetStringBuilder();
		}


		protected virtual void Dispose(bool isManagedDispose)
		{
			if (!_isDisposed)
			{
				if (isManagedDispose)
				{
					_textWriter.Dispose();
				}

				_isDisposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(isManagedDispose: true);
			GC.SuppressFinalize(this);
		}
	}
}