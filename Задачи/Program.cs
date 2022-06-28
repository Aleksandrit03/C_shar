// Возводит число в квадрат
// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Квадрат числа: {square}");

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
Console.WriteLine("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number2*number2;
if (number1 == square)
{
    Console.WriteLine($"Число {number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не является квадратом {number2}");
}