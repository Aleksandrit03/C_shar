// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
namespace Zadacha38
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          int [] array = new int [new Random().Next(4, 6)];
          Random random = new Random();
          int i = 0;
          while (i < array.Length)
          {
            array [i] = random.Next(-100, 100);
            Console.WriteLine($" {array[i]} ");
            i++;
          }
          int max = array[0];
          int min = array[0];
          i=0;
          while (i < array.Length)
          {
          if (array [i] > max)
          {
            max = array [i];
          }
          else if (array [i] < min)
          {
            min = array [i];
          }
            else i++;
          }
          int result = max - min;
          Console.WriteLine($"Разница максимального и минимального значения: {result}");
          Console.ReadKey();
         }
     }  
}   

