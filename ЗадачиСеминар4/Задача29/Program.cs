// Напишите программу, которая задает случайный массив случайного размера 
// (от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран 
// массив квадратов этих чисел.
namespace Zadacha29
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          Console.WriteLine("Массив до возведения чисел в квадрат: ");
          int [] array = new int [new Random().Next(5,10)];
          for (int i = 0; i < array.Length; i++)
          {
            array [i] = Random.Next(1, 40);
          }
           for (int i = 0; i < array.Length; i++)
          {
            array [i] = Math.Pow(i, 2);
          }
          Console.WriteLine($"{array[i]}");
         }
     }  
}   

