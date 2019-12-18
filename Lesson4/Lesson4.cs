using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace netcourse
{
    class Lesson4
    {
        /// <summary>
        /// Стефаненко
        /// 1)
        /// Дан  целочисленный  массив  из 20 элементов.  
        /// Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
        /// Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
        /// В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
        /// 2) Реализуйте задачу 1 в виде статического класса StaticClass;
        /// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        /// </summary>

        static void Main(string[] args)
        {
           var s = CreateArray(20);
            SearchCouples(s);
            Wait.Pause();
        }

        static int[] CreateArray( int sizeArray)
        {
            int[] arr = new int[sizeArray];

            Random r = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
                arr[i] = r.Next(-10_000, 10_000);
            };

            PrintData.Print("Изначальный массив", arr);
            return arr;
        }

        static int SearchCouples(int[] array)
        {
            int cost = 0;


            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i+1] == 0 && (array[i] % 3) == 0)
                {
                    cost++;
                }
                else if ((array[i]% 3) == 0 && (array[i+1] % 3) != 0)
                {
                    cost++;
                }
                else if ((array[i+1] % 3) == 0 && (array[i] % 3) != 0)
                {
                    cost++;
                }
            };

            PrintData.Print("Количесто пар ", cost);
            return cost;
        }
    }
}
