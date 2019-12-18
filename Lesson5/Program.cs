using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5
{
	class Program
	{
		/// <summary>
		/// стефаненко
		/// Создать программу, которая будет проверять корректность ввода логина.
		/// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
		/// а) без использования регулярных выражений;
		/// б) **с использованием регулярных выражений.

		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine("Введите логин");
			char[] logon =Console.ReadLine().ToCharArray();

			if (logon.Length>10 && logon.Length<2)
			{
				Console.WriteLine("Введите логин от 2  до 10  символов");
			}

			else if(!char.IsDigit(logon.First()))
			{
				Console.WriteLine("Введите логин не должен начинаться с цифры");
			}
			else if(!Validate(logon))
			{
				Console.WriteLine("Введите логин содержащий только цифры и латинские буквы");
			}
			else
			{
				Console.WriteLine("Вы ввели корректный логин");
			}


			Regex regex = new Regex(@"(^[a-z]|^[A-Z]){1}(\d|[a-z]|[A-Z]){1,9}$");

			Console.WriteLine("regex говорит, что логин " + (regex.IsMatch(logon.ToString()) ? "корректен" : "некорректен"));


		}

		private static bool Validate(char[] logon)
		{
			bool check = false;

			foreach (char a in logon)
			{
				if ((a >= 'A' && a <= 'Z') || (a >= 'a' && a <= 'z') || char.IsDigit(a))
				{
					check = true;
				}
				else
				{
					check = false;
					break;
				}
			}

			return check;
		}
	}
}
