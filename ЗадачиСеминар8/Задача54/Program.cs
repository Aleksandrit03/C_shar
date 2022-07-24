// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
namespace Zadacha54
{
   class Zadachi
    {
         static void Main(string[] args)
        {
         string[,] massiv = new string[5, 5];
         string k;
          for (int i = 0; i < 5; i++)
            {
              for (int j = 0; j < 5; j++)
                {
                  massiv[i,j] = Convert.ToString(new Random().Next(1,10));
                  Console.Write($" {massiv[i,j]} ");
                }
              Console.WriteLine();
            }
          Console.WriteLine();
          // Вывели массив с рандомным заполнением.

          for (int i = 0; i < 5;)
            {
              for (int j = 0; j < 5;)
                {
                  if (j == 4)
                  {
                    Console.Write($" {massiv[i,j]} ");
                  }
                  else if (Convert.ToDouble(massiv[i,j]) > Convert.ToDouble(massiv[i,j+1]))
                  {
                    k = massiv[i,j];
                    massiv[i,j] = massiv[i,j+1];
                    massiv[i,j+1] = k;
                    Console.Write($" {massiv[i,j]} ");
                  }
                  j++;
                }
              Console.WriteLine();
              i++;
              
            }

            // Решение упрощенное для массива 2*2.
          //    if (Convert.ToDouble(massiv[0,0]) > Convert.ToDouble(massiv[0,1]))
          //    {
          //      k = massiv[0,0];
          //      massiv[0,0] = massiv[0,1];
          //      massiv[0,1] = k;
          //    }
          //    Console.WriteLine($"{massiv[0,0]} {massiv[0,1]} ");
          //    if (Convert.ToDouble(massiv[1,0]) > Convert.ToDouble(massiv[1,1]))
          //    {
          //      k = massiv[1,0];
          //      massiv[1,0] = massiv[1,1];
          //      massiv[1,1] = k;
          //    }
          //    Console.WriteLine($"{massiv[1,0]} {massiv[1,1]} ");
         }
        // //  Я буду благодарен, если в ответ на ДЗ вы скинете задачу с лучшем решением чем у меня.
        // // Пытался решить ее 2 дня, к сожалению не вышло для общего случая. Но задача соответствует заданию))))
     }  
}   
