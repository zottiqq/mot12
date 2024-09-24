using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            Console.WriteLine("5 - Периметр прямоугольника");
            Console.WriteLine("6 - Площадь прямоугольника");
            Console.WriteLine("0 - Выход");

            string choice = Console.ReadLine();

            if (choice == "0")
                break;

            double num1, num2;

            switch (choice)
            {
                case "1": // Сложение
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;

                case "2": // Вычитание
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;

                case "3": // Умножение
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;

                case "4": // Деление
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                        Console.WriteLine($"Результат: {num1 / num2}");
                    else
                        Console.WriteLine("Ошибка: Деление на ноль!");
                    break;

                case "5": // Периметр прямоугольника
                    Console.Write("Введите длину прямоугольника: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите ширину прямоугольника: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Периметр: {2 * (length + width)}");
                    break;

                case "6": // Площадь прямоугольника
                    Console.Write("Введите длину прямоугольника: ");
                    length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите ширину прямоугольника: ");
                    width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь: {length * width}");
                    break;

                default:
                    Console.WriteLine("Недопустимый ввод. Пожалуйста, попробуйте еще раз.");
                    break;
            }

            Console.WriteLine(" --------------------------- ");
        }
    }
}
