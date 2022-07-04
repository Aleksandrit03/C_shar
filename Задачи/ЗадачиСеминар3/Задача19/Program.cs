// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

namespace Zadacha10
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          Console.WriteLine("Введите пятизначное число: ");
          string number = Console.ReadLine();
          if (number.Length != 5)
            {
              Console.WriteLine($"Введенное число {number} не является пятизначным");
            }
          else if (number[0] == number[4] & number[1] == number[3])
            {
               Console.WriteLine($"Введенное число {number} является палиндромом");
            } 
        else 
            {
             Console.WriteLine($"Введенное число {number} не является палиндромом"); 
            }
         Console.ReadKey();
         }
     }  
}   
