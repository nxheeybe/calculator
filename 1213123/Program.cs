using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double num1, num2, result;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычитание");
                Console.WriteLine("3.Умножение");
                Console.WriteLine("4.Деление");
                Console.WriteLine("5.Возведение в степень");
                Console.WriteLine("6.Квадратный корень");
                Console.WriteLine("7.1 процент от числа");
                Console.WriteLine("8.Факториал");
                Console.WriteLine("9.Выход");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите 1 число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите 2 число:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 2:
                        Console.WriteLine("Введите 1 число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите 2 число:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 3:
                        Console.WriteLine("Введите 1 число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите 2 число:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 4:
                        Console.WriteLine("Введите 1 число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите 2 число:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 == 0)
                        {
                            Console.WriteLine("Как выхотите делить на 0?.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine("Результат: " + result);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень:");
                        int power = Convert.ToInt32(Console.ReadLine());
                        result = Math.Pow(num1, power);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 6:
                        Console.WriteLine("Введите число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Math.Sqrt(num1);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 7:
                        Console.WriteLine("Введите число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * 0.01;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 8:
                        Console.WriteLine("Введите число:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Factorial(num1);
                        Console.WriteLine("Результат: " + result);
                        break;
                    case 9:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Выбирите нормально!.");
                        break;
                }
            }
        }

        static double Factorial(double n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}


