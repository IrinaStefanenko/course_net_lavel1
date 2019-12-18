using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
	/// <summary>
	/// Стефаненко
	/// 3. Переделать программу «Пример использования коллекций» для решения следующих задач:
	/// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
	/// </summary>
	class Task3
	{
		static int MyDelegat(Students st1, Students st2)          // Создаем метод для сравнения для экземпляров
		{

			return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
		}


		static void Main(string[] args)
		{
			int bakalavr = 0;
			int magistr = 0;
			int six = 0;
			int five = 0;
			List<Students> list = new List<Students>();                             // Создаем список студентов
			DateTime dt = DateTime.Now;
			StreamReader sr = new StreamReader("students.cvs");
			while (!sr.EndOfStream)
			{
				try
				{
					string[] s = sr.ReadLine().Split(';');
					// Добавляем в список новый экземпляр класса Student
					list.Add(new Students(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
					// Одновременно подсчитываем количество бакалавров и магистров
					if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
					if (int.Parse(s[6]) == 5) five++;
					if (int.Parse(s[6]) == 6) six++;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
					// Выход из Main
					if (Console.ReadKey().Key == ConsoleKey.Escape) return;
				}
			}
			sr.Close();
			list.Sort(new Comparison<Students>(MyDelegat));
			Console.WriteLine("Всего студентов:" + list.Count);
			Console.WriteLine("Магистров:{0}", magistr);
			Console.WriteLine("Бакалавров:{0}", bakalavr);
			foreach (var v in list) Console.WriteLine(v.firstName);
			Console.WriteLine(DateTime.Now - dt);

			// учащиеся на 5 и 6 курсах
			Console.WriteLine("На 5 курсе:{0}", five);
			Console.WriteLine("На 6 курсе:{0}", six);


			Console.ReadKey();
		}

	}
}
