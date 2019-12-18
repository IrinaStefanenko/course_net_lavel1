using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
	/// Стефаненко Ирина
	/// <summary>
	/// 2) Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
	/// а) Сделать меню с различными функциями и представить пользователю выбор,
	/// для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
	/// </summary>
	class Task2
	{
		public delegate double Deligates(double x);

		public static double F(double x)
		{
			return x * x - 50 * x + 10;
		}
		public static double J(double x)
		{
			return x + 10 - 5;
		}
		public static double K(double x)
		{
			return x * x;
		}
		public static void SaveFunc(string fileName, double a, double b, double h, Deligates del)
		{
			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);
			double x = a;
			while (x <= b)
			{
				bw.Write(del(x));
				x += h;// x=x+h;
			}
			bw.Close();
			fs.Close();
		}

		public static double Load(string fileName)
		{
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryReader bw = new BinaryReader(fs);
			double min = double.MaxValue;
			double d;
			for (int i = 0; i < fs.Length / sizeof(double); i++)
			{
				// Считываем значение и переходим к следующему
				d = bw.ReadDouble();
				if (d < min) min = d;
			}
			bw.Close();
			fs.Close();
			return min;
		}
	/*	static void Main(string[] args)
		{
			List<Deligates> listDel = new List<Deligates>
				{
					F,
					K,
					J
				};
			Console.WriteLine("Ведите x ");
			double x = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Ведите y");
			double y = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ведите h");
			double h = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Ведите функцию от 1 до 3");
			int fun = Convert.ToInt32(Console.ReadLine());

			if (listDel.Count >= fun)
				{
					SaveFunc("data.bin", x, y, h, listDel[fun - 1]);
				}

			Console.WriteLine(Load("data.bin"));
			Console.ReadKey();
		}
		*/
	}
}

