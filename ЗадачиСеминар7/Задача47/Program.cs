// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
namespace Zadacha47
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             Console.WriteLine("Введите значение строк m: ");
             int m = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите значение столбцов n: ");
             int n = Convert.ToInt32(Console.ReadLine());
             string[,] massiv = new string[m, n];
             for (int rows = 0; rows < m; rows++)
             {
                for (int columns = 0; columns < n; columns++)
                {
                  Console.Write($"{massiv[rows, columns]}0");
                }
             }
               Console.WriteLine();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        massiv[i,j] = Convert.ToString(new Random().Next(1,10));
                        Console.Write($" {massiv[i,j]} ");
                    }
                    Console.WriteLine();
                }
         }
     }  
}   
