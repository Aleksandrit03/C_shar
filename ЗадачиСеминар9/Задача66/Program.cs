//  Задайте значения M и N. Напишите программу, которая найдёт 
//  сумму натуральных элементов в промежутке от M до N.
namespace Zadacha66
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             Console.WriteLine("Введите значение M: ");
             int M = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите значение N: ");
             int N = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"M: {M} N: {N} ");
             int result = 0;
             while(M <= N)
             {
               result += M;
               M++;
             }
             Console.Write($"{result}");
             Console.ReadKey();
         }
     }  
}   