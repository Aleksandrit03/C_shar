// Задача41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
namespace Zadacha41
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             Console.WriteLine("Введите числа через пробел: ");
             string? massiv = Console.ReadLine();
             string [] numbers = massiv.Split(' ');
             int i = 0;
             int result = 0;
             Console.WriteLine("Преобразованно в массив: ");
             while (i < numbers.Length)
             {
                Console.Write($" {numbers[i]} ");
                i++;
                if (numbers [i] > 0) result++;
             }
         }
     }  
}   
