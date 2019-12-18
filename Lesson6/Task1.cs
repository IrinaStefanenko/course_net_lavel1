using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
	class Task1
	{
		/// Стефаненко Ирина
		/// <summary>
		/// 1)  Изменить программу вывода таблицы функции так,
		/// чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
		/// </summary>
		/// 
		public delegate double Fun(double x, double a);
		// Создаем метод, который принимает делегат
		// На практике этот метод сможет принимать любой метод
		// с такой же сигнатурой, как у делегата
		public static void Table(Fun F, double x, double b)
		{
			Console.WriteLine("----- X ----- Y -----");
			while (x <= b)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
				x += 1;
			}
			Console.WriteLine("---------------------");
		}

		// Создаем метод для передачи его в качестве параметра в Table
		public static double Sin(double x, double a)
		{
			return a * Math.Sin(x);
		}

		// Создаем метод для передачи его в качестве параметра в Table
		public static double Con(double x, double a)
		{
			return a * x * x;
		}

		/*		static void Main(string[] args)
		{

			Console.WriteLine("Таблица Sin");
			// функция   a*sin(x)          
			Table(Sin, -2, 5);
			Console.WriteLine("Таблица Con");
			// функция   a*x^2           
			Table(Con, -2,5);

			Console.ReadKey();
		}
		*/
	}
}
