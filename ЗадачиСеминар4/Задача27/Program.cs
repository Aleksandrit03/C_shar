// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
namespace Zadacha27
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          Console.WriteLine("Введите число: ");
          int number = Convert.ToInt32(Console.ReadLine());
          int result = 0;
          while (number > 0)
          {
            result = result + number%10;
            number = number / 10;
          }
          result = result + number;
          Console.WriteLine($"Сумма цифр в числе равна {result}");
         }
     }  
}   
