using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void NavigateMenu(int numOfTask)
        {
            switch(numOfTask)
            {
                case 1:
                    Console.WriteLine("Пример if...else");
                    Console.WriteLine("Проверка на четность");
                    ExampleIf();
                    break;
                case 2:
                    Console.WriteLine("\nПример switch");
                    Console.WriteLine("Калькулятор:");
                    ExampleSwitch();
                    break;
                case 3:
                    Console.WriteLine("\nПример контролируемого цикла");
                    Console.WriteLine("Квадратный корень из числа");
                    ExampleDoWhile();
                    break;
                case 4:
                    Console.WriteLine("\nПример continue");
                    Console.WriteLine("Вывод на экран последовательность от 1 до 10, но вывести только нечетные");
                    ExampleContinue();
                    break;
                case 5:
                    Console.WriteLine("\nПример goto");
                    Console.WriteLine("Goto");
                    ExampleGoto();
                    break;

                default:
                    Console.WriteLine("Примера с таким номером не существует");
                    break;

            }
        }
        static void ExampleIf()
        {
            Console.WriteLine("Введите целое число: ");
            int number=int.TryParse(Console.ReadLine(), out int res) ? res : -1;
            string result;

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    result = "четное число";
                }
                else
                {
                    result = "нечетное число";
                }
            }
            else
            {
                result = "введено не целове число";
            }
            Console.WriteLine("{0} это {1}", number, result);
        }
        static void ExampleSwitch()
        {
            char op;
            double first, second, result;

            Console.Write("Введите первое число: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите оператор (+, -, *, /): ");
            op = (char)Console.ReadLine()[0];

            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;

                default:
                    Console.WriteLine("Недопустимый оператор");
                    break;

            }
        }
        static void ExampleDoWhile()
        {
            string input = String.Empty;
            do
            {
                Console.WriteLine("Введите число для вычисления квадратного корня (нажмите E или e для выхода): ");
                input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    if (number >= 0)
                    {
                        Console.WriteLine($"Квадратный корень: {Math.Sqrt(number): 0.##}");
                    }
                    else
                    {
                        Console.WriteLine("Введите число больше 0");
                    }
                }
            }
            while (!(input.Equals("E") || input.Equals("e")));
        }
        static void ExampleContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"{i}");
            }
        }
        static void ExampleGoto()
        {
            int counter = 0;

        Label:
            counter++;
            Console.WriteLine("Counter = {0}", counter);

            if (counter < 3)
            {
                goto Label;
            }

            Console.WriteLine("End");
        }
        static void Main(string[] args)
        {
            string input = String.Empty;
            do
            {
                Console.WriteLine("Введите номер примера:\n 1. If...else,\n " +
                "2. Switch,\n " +
                "3.Контролируемый цикл, \n " +
                "4.Continue, \n " +
                "5.Goto\nДля выхода нажмите e или E");

                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    NavigateMenu(result);
                }
                else
                {
                    Console.WriteLine("Не удалось преобразовать входные параметры");
                }
            }
            while (!(input.Equals("E") || input.Equals("e")));
            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
