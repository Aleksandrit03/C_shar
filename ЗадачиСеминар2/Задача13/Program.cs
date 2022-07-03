// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
namespace Zadacha10
{
   class Zadachi
    {
         static void Main(string[] args)
         {
          Console.WriteLine("Введите число: "); 
          int x = Convert.ToInt32(Console.ReadLine());
          if (x < 100 || x > 999)
            {
                Console.WriteLine("Введено не трёхзначное число");
            }
            else 
              {
              x = x % 100;
              x = x / 10;
              Console.WriteLine($"Второе цифра это: {x}");
              }
         }

     }  
}   
