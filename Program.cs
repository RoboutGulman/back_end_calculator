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

                string action;
                var operands = ReadOperands();

                if (operands == null)
                {
                    continue;
                }

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = Console.ReadLine();

                var result = ResolveExpression(operands, action);

                if (result != null)
                {
                    Console.WriteLine(result);
                }

                Console.ReadLine();
            }
        }

        private static Tuple<double, double> ReadOperands()
        {
            Tuple<double, double> operands;
            try
            {
                Console.WriteLine("Введите число 1");
                double firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число 2");
                double secondValue = double.Parse(Console.ReadLine());
                operands = new Tuple<double, double>(firstValue, secondValue);
            }
            catch (Exception)
            {
                Console.WriteLine("не удалось преобразовать строку в число");
                Console.ReadLine();
                return null;
            }
            return operands;
        }

        private static double? ResolveExpression(Tuple<double, double> operands, string action)
        {
            double result;
            switch (action)
            {
            case "+":
                result = operands.Item1 + operands.Item2;
                break;
            case "-":
                result = operands.Item1 - operands.Item2;
                break;
            case "*":
                result = operands.Item1 * operands.Item2;
                break;
            case "/":
                if (operands.Item2 == 0)
                {
                    Console.WriteLine("Ошибка! Делить на ноль нельзя");
                    return null;
                }
                else
                {
                    result = operands.Item1 / operands.Item2;
                }
                break;
            default:
                Console.WriteLine("Ошибка! Неизвестное действие!");
                return null;
            }
            return result;
        }
    }
}
