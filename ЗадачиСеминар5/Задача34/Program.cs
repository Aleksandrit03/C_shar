// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
namespace Zadacha34
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          int [] array = new int [new Random().Next(8, 10)];
          Random random = new Random();
          int result = 0;
          int i = 0;
          while (i < array.Length)
          {
            array [i] = random.Next(100, 1000);
            Console.WriteLine($" {array[i]} ");
            i++;
          }
          i = 0;
          while (i < array.Length)
          {
            if (array[i] % 2 ==0)
            result++;
            i++;
          }
          Console.WriteLine($"Количество четных чисел: {result}");
         }
     }  
}   