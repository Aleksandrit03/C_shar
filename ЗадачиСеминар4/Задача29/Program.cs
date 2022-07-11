// Напишите программу, которая задает случайный массив случайного размера 
// (от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран 
// массив квадратов этих чисел.
namespace Zadacha29
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          int [] array = new int [new Random().Next(5, 10)];
          Random random = new Random();
          for (int i = 0; i < array.Length; i++)
          {
            array [i] = random.Next(1, 40);
            Console.WriteLine($" {i} ");
          }
          Console.WriteLine("Квадраты чисел массива: ");
           for (int i = 0; i < array.Length; i++)
          {
            array [i] = Convert.ToInt32(Math.Pow(i, 2));
            Console.WriteLine($"{array[i]}");
          }
         }
     }  
}   

