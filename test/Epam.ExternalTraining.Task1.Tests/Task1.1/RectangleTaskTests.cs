using Epam.ExternalTraining.Abstractions;
using Epam.ExternalTraining.Abstractions.Task1_1;
using Epam.ExternalTraining.Task1.TheMagnificentTen;
using Moq;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace Epam.ExternalTraining.Task1.Tests
{
	public class RectangleTaskTests
	{
		private IRectangleTask _rectangleTask;

		[SetUp]
		public void Setup()
		{
			_rectangleTask = new RectangleTask();
		}


		[TestCase(2,2,4)]
		[TestCase(8235, 15326, 126209610)]
		public void Run_RegularNumbers_ShouldWriteTheAreaResult(int a, int b, int expectedResult)
		{
			// Arrange
			var consoleMock = new Mock<IConsole>(MockBehavior.Loose);

			consoleMock.SetupSequence(c => c.ReadLine())
				.Returns(a.ToString())
				.Returns(b.ToString())
				.Throws(new Exception("Unexpected call to ReadLine"));

			// Act
			_rectangleTask.Run(consoleMock.Object);

			// Assert
			consoleMock.Verify(c => c.WriteLine(expectedResult.ToString()), "Expected to get a call with rectangle's area"); 
		}

		[TestCase(0, 2), TestCase(-1, 2)]
		[TestCase(2, 0), TestCase(2, -254)]
		[TestCase(0, 0), TestCase(-242743, 0)]
		public void Run_Zero_ShouldWhat(int a, int b)
		{
			// Arrange
			var consoleMock = new Mock<IConsole>(MockBehavior.Loose);

			consoleMock.SetupSequence(c => c.ReadLine())
				.Returns(a.ToString())
				.Returns(b.ToString())
				.Throws(new Exception("Unexpected call to ReadLine"));

			// Act
			_rectangleTask.Run(consoleMock.Object);

			// Assert

			consoleMock.Verify(
				c => c.WriteLine(It.Is<string>(s => !Regex.IsMatch(s.Trim(), @"^-?\d+$"))), 
				"Expected an error message about incorrect input");
		}

	}
}