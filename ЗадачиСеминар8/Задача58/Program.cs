//  Задайте две матрицы. Напишите программу, которая выведет матрицу 
// произведения элементов двух предыдущих матриц.
namespace Zadacha58
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             string[,] massiv = new string[3, 3];
             for (int i = 0; i < 3; i++)
             {
                for (int j = 0; j < 3; j++)
                {
                    massiv[i,j] = Convert.ToString(new Random().Next(1,10));
                    Console.Write($" {massiv[i,j]} ");
                }
                Console.WriteLine();
             }
            Console.WriteLine();

            string[,] mass = new string[3, 3];
             for (int i = 0; i < 3; i++)
             {
                for (int j = 0; j < 3; j++)
                {
                    mass[i,j] = Convert.ToString(new Random().Next(1,10));
                    Console.Write($" {mass[i,j]} ");
                }
                Console.WriteLine();
             }
            Console.WriteLine();
            int[,] resultMass = new int [3, 3];
            for (int i = 0; i < 3; i++)
             {
                for (int j = 0; j < 3; j++)
                {
                    resultMass[i,j] = Convert.ToInt32(massiv[i,j]) * Convert.ToInt32(mass[i,j]);
                    Console.Write($" {resultMass[i,j]} ");
                }
                Console.WriteLine();
             }
            Console.WriteLine();
            Console.ReadKey();
         }
     }  
}   

