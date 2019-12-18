using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcourse
{
    class lesson1
    {
       static void Main(string[] args)
        {
            // WorkSheet();
            // Weight();
            // Distance();
            // ChangeValue();
            Position();
            Console.ReadKey();
        }

        static void WorkSheet()
        {
            Console.WriteLine("Ведите имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Ведите фамилию:");
            var surname = Console.ReadLine();
            Console.WriteLine("Веедите возраст:");
            var adge = Console.ReadLine();

            Console.WriteLine("Ваше имя " + name + " " +  surname + " возраст " + adge);
            Console.WriteLine("Ваще имя {0} {1} возраст {2}", name, surname, adge);
            Console.WriteLine($"Ваще имя {name} {surname} возраст {adge}");
        }

        static void Weight()
        {
            Console.WriteLine("Ведите вес:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("еедите рост:");
            double height = Convert.ToDouble(Console.ReadLine());

            double index = weight/(height * height);
            Console.WriteLine($"Ваш индекс массы тела: {index}");

        }

        static void Distance()
        {
            Console.WriteLine("Ведите  x для первой точки");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите y для первой точки");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ведите  x для второй точки");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите y для второй точки");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = Convert.ToSingle(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine($"Растояние между точками {r,10:f2}");
        }

        static void ChangeValue()
        {

            int a = 10;     
            int b = 20;
            int t = a;        
            a = b;           
            b = t;           
        }


        static void Position()
        {
            Console.WriteLine("Ведите имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Ведите фамилию:");
            var surname = Console.ReadLine();
            Console.WriteLine("Веедите город проживания:");
            var city = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Ваше имя {name} {surname} и город {city}");

            Console.SetCursorPosition(10,10); // как найти цент экрана не представляю  ((
            Console.WriteLine($"Ваше имя {name} {surname} и город {city}");

            Print($"Ваше имя {name} {surname} и город {city}", 20, 5); //можно передавать каждую переменную, но не считаю метод должен быть более универсальным

        }

        static void Print(string data, int x, int y)
        {
            Console.SetCursorPosition(5, 5); 
            Console.WriteLine(data);
        }
    }
}

