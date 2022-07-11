// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
namespace Zadacha25
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          Console.WriteLine("Введите первое число: ");
          int A = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Введите второе число: ");
          int B = Convert.ToInt32(Console.ReadLine());
          double result = 1;
          int i = 1;
          while (i <= B)
          {
               result = result * A;
               i++;
          }
          Console.WriteLine($"{result}");
          Console.ReadKey();
         }
     }  
}   