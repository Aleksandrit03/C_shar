// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
namespace Zadacha54
{
   class Zadachi
    {
         static void Main(string[] args)
        {
         string[,] massiv = new string[2, 2];
         string k;
          for (int i = 0; i < 2; i++)
            {
              for (int j = 0; j < 2; j++)
                {
                  massiv[i,j] = Convert.ToString(new Random().Next(1,10));
                  Console.Write($" {massiv[i,j]} ");
                }
              Console.WriteLine();
            }
          Console.WriteLine();
           if (Convert.ToDouble(massiv[0,0]) > Convert.ToDouble(massiv[0,1]))
           {
             k = massiv[0,0];
             massiv[0,0] = massiv[0,1];
             massiv[0,1] = k;
           }
           Console.WriteLine($"{massiv[0,0]} {massiv[0,1]} ");
           if (Convert.ToDouble(massiv[1,0]) > Convert.ToDouble(massiv[1,1]))
           {
             k = massiv[1,0];
             massiv[1,0] = massiv[1,1];
             massiv[1,1] = k;
           }
           Console.WriteLine($"{massiv[1,0]} {massiv[1,1]} ");
         }
        //  Я буду благодарен, если в ответ на ДЗ вы скинете задачу с лучшем реением чем у меня.
        // Пытался решить ее 2 дня, к сожалению не вышло для общего случая. Но задача соответствует заданию))))
     }  
}   
