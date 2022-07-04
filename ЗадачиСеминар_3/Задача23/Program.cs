// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
namespace Zadacha23
{
   class Zadacha
    {
         static void Main(string[] args)
        {
          Console.WriteLine("Введите число: ");
          int N = Convert.ToInt32(Console.ReadLine());
          int i = 0;
          while(i <= N)
          {
            double result = Math.Pow(i, 3);
            Console.WriteLine($"Куб числа {i} равен {result}");
            i++;
          }
         Console.ReadKey();
         }
     }  
}   
