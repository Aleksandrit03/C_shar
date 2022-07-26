//  Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
namespace Zadacha64
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
             while(M <= N)
             {
               Console.Write($"{M} ");
               M++;
             }
             Console.ReadKey();
         }
     }  
}   