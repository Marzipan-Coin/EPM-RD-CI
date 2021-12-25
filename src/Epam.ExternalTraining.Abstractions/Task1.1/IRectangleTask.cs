﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.ExternalTraining.Abstractions.Task1._1
{
	/// <summary>
	/// Написать программу, которая определяет площадь прямоугольника со сторонами a и b. 
	/// Если пользователь вводит некорректные значения(отрицательные или ноль), должно выдаваться сообщение об ошибке.
	/// Возможность ввода пользователем строки вида «абвгд» или нецелых чисел игнорировать (пренебречь).
	/// </summary>
	interface IRectangleTask
	{
		/// <summary>
		/// Метод должен содержать логику, считывающую пользовательский ввод из консоли и выводящий результат обратно в консоль
		/// </summary>
		void Run();
	}
}
