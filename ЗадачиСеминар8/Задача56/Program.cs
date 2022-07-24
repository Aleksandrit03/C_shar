// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
namespace Zadacha56
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             string[,] massiv = new string[3, 4];
             double result = 0;
             for (int i = 0; i < 3; i++)
             {
                for (int j = 0; j < 4; j++)
                {
                    massiv[i,j] = Convert.ToString(new Random().Next(1,10));
                    Console.Write($" {massiv[i,j]} ");
                }
                Console.WriteLine();
             }
            Console.WriteLine();
            int k = 0;
            int l = 0;
            int n = 1;
            double n1 = 0; 
            double n2 = 0; 
            double n3 = 0;
            while (k <= 2 && l <= 3)
               {
                while (l <= 3)
                {
                   result += Convert.ToDouble(massiv[k,l]);
                   l++;
                }
                Console.WriteLine($"Сумма чисел строки {n} = {result}");
                if (n==1)
                  {
                    n1 = result;
                    }
                if (n==2)
                  {
                    n2 = result;
                    }
                if (n==3) 
                 {
                    n3 = result;
                    }
                 result = 0;
                 l = 0;
                 k++;
                 n++;
               }
            Console.WriteLine();
            if (n1 < n2 && n1 < n3)
              {
                Console.WriteLine($"Сумма чисел 1 строки({n1}) наименьшая");
              }
            if (n2 < n1 && n2 < n3)
               {
                Console.WriteLine($"Сумма чисел 2 строки({n2}) наименьшая");
               }
               if (n3 < n1 && n3 < n2)
               {
                Console.WriteLine($"Сумма чисел 3 строки({n3}) наименьшая");
               }
            Console.WriteLine();
            Console.ReadKey();
         }
     }  
}   
