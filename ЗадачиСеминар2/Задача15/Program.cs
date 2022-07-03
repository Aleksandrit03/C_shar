
namespace Zadacha10
{
   class Zadachi
    {
         static void Main(string[] args)
         {
          // Напишите программу, которая принимает на вход цифру, 
          // обозначающую день недели, и проверяет, является ли этот день выходным.
          Console.WriteLine("Введите число от 1 до 7: ");
          int x = Convert.ToInt32(Console.ReadLine());

          if (x > 0 && x < 6)
            {
             Console.WriteLine("Нет");
            }

          if (x > 5 && x < 8)
            {
             Console.WriteLine("Да");
            }

          if (x > 7)
            {
             Console.WriteLine("Данное число вне диапазона");
            }
Console.ReadKey();
         }

     }  
}   