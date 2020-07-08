using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pract9
{
    class Program
    {
        private const String PATH = "..\\..\\..\\text.txt";
        static void Main(string[] args)
        {
            Console.Write("Введите размер числового ряда: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            Console.WriteLine("Введите числовой ряд: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("№ " + (i + 1) + ": ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите нижнюю границу числового ряда: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу числового ряда: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Числа ряда, попадающие в границы: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= a && arr[i] <= b)
                {
                    Console.Write(arr[i] + "; ");
                    File.AppendAllText(PATH, Convert.ToString(arr[i]));
                }
            }
            Console.ReadKey();
        }
    }
}