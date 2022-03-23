using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;
                try
                {
                    Console.WriteLine("Введите число 1");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Ошибка! Делить на ноль нельзя");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка! Неизвестное действие!");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
