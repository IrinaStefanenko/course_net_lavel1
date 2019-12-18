using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class PrintData
    {
        /// <summary>
        /// Print to console by coordinates
        /// </summary>
        /// <param name="data"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Print(string data, int x, int y)
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine(data);
        }

        /// <summary>
        /// Print to console
        /// </summary>
        /// <param name="data"></param>
        static void Print(string data)
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine(data);
        }

        /// <summary>
        /// Print array to console
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        public static void Print(string message, int[] data)
        {
            Console.WriteLine(message);

            foreach (int arr in data)
            {
                Console.WriteLine(arr);
            }
        }

        /// <summary>
        /// Print array to console
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        public static void Print(string message, int data)
        {
            Console.WriteLine(message);
            Console.WriteLine(data);

        }


    }
}
