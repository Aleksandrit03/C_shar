// Задача41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
namespace Zadacha41
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             Console.WriteLine("Введите количество чисел, которое хотите ввести: ");
             int size = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();
             int number = 0;
             int result = 0;
             while(number < size)
             {
               Console.Write("Введите число: ");
               int i = Convert.ToInt32(Console.ReadLine());
               if (i > 0)
               {
                  result++;
                  number++;
               }
               else number++;
               Console.WriteLine();
             }
             Console.WriteLine($"Количество чисел больше нуля: {result}");
         }
     }  
}   
