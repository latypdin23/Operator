using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
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
        static void ExampleBreak()
        {
            while (true)
            {
                Console.WriteLine("Введите число для вычисления квадратного корня (нажмите E или e для выхода): ");

                string num=Console.ReadLine();

                if (num == "E" || num == "e")
                {
                    break;
                }

                // convert the input string to a double
                double number = Convert.ToDouble(num);

                // start the new iteration if the number is negative
                if (number < 0)
                {
                    Console.WriteLine("Введите число");
                    continue;
                }

                Console.WriteLine($"Квадратный корень: {Math.Sqrt(number): 0.##}");


            }
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
        static void Main(string[] args)
        {
            /*Console.WriteLine("Пример if...else");
            Console.WriteLine("Проверка на четность");
            ExampleIf();*/
            Console.WriteLine("\nПример switch");
            Console.WriteLine("Калькулятор:");
            ExampleSwitch();

            Console.WriteLine("\nПример break");
            Console.WriteLine("Квадратный корень из числа(плохой способ)");
            ExampleBreak();

            Console.WriteLine("\nПример continue");
            Console.WriteLine("Вывод на экран последовательность от 1 до 10, но вывести только нечетные");
            ExampleContinue();

            Console.WriteLine("\nПример goto");
            Console.WriteLine("\nПример Exception");
            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
