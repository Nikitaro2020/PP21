using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите операцию: +, -, /, *");
            string input = Console.ReadLine();

            switch (input)
            {
                case "+":
                    Console.WriteLine($"Результат сложения: {A + B}");
                    break;
                case "-":
                    Console.WriteLine($"Результат вычитания: {B - A}");
                    break;
                case "*":
                    Console.WriteLine($"Результат умножения: {A * B}");
                    break;
                case "/":
                    if (B != 0)
                    {
                        Console.WriteLine($"Результат деления: {A / (double)B}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: неверная операция!");
                    break;
            }
        }
    }
}
