using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3semlaba4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма: " + Convert.ToDouble(A + B));
            Console.WriteLine("Разность: " + Convert.ToString(A - B));
            Console.WriteLine("Умножение: " + Convert.ToString(A * B));
            Console.WriteLine("Деление: " + Convert.ToString(A / B));
        }
    }
}
