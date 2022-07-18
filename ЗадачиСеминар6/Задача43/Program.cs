// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
namespace Zadacha43
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             Console.WriteLine("Введите значение b1: ");
             double b1 = Convert.ToDouble (Console.ReadLine ());
             Console.WriteLine("Введите значение k1: ");
             double k1 = Convert.ToDouble (Console.ReadLine ());
             Console.WriteLine("Введите значение b2: ");
             double b2 = Convert.ToDouble (Console.ReadLine ());
             Console.WriteLine("Введите значение k2: ");
             double k2 = Convert.ToDouble (Console.ReadLine ());
             Console.WriteLine($"Введенные данные: b1 = {b1}, b2 = {b2}, k1 = {k1}, k2 = {k2}");
             double x = (b2 - b1)/(k1 - k2); // Преобразование формулы
             double y = k1*x + b1;
             Console.WriteLine($"Координата пересечения прямых: x = {x}, y = {y} ");
         }
     }  
}   




