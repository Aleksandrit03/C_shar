// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
namespace Zadacha10
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          Console.WriteLine("Введите число: "); 
          string str = Console.ReadLine();
          Console.WriteLine(str[str.Length - 2]);
         }
     }  
}   

