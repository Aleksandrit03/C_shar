// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
namespace Zadacha36
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          int [] array = new int [new Random().Next(4, 6)];
          Random random = new Random();
          int result = 0;
          int i = 0;
          while (i < array.Length)
          {
            array [i] = random.Next(-10, 10);
            Console.WriteLine($" {array[i]} ");
            i++;
          }
          i=1;
          while (i < array.Length)
          {
            result = result + array[i];
            i = i + 2;
          }
          Console.WriteLine($"Сумма чисел на нечетных позициях: {result}");
          Console.ReadKey();
         }
     }  
}   

