// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// if (x1 > x2)
// {
//     Console.WriteLine("Первое число больше второго");
// }

// if (x2 > x1)
// {
//     Console.WriteLine("Второе число больше первого");
// }
// if (x2==x1)
// {
//     Console.WriteLine("Числа равны, хоть этого от программы и не требовалось");
// }
// Console.ReadKey();

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int x3 = Convert.ToInt32(Console.ReadLine());

// if (x1 > x2 & x1 > x3)
// {
//     Console.WriteLine("Первое число максимальное из чисел");
// }

// if (x2 > x1 & x2 > x3)
// {
//     Console.WriteLine("Второе число максимальное из чисел");
// }

// if (x3 > x1 & x3 > x2)
// {
//     Console.WriteLine("Третье число максимальное из чисел");
// }
// Console.ReadKey();

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// // (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
 
// if (x % 2 == 0)
// {
//    Console.WriteLine("Число четное");
// }
// else 
// {
//     Console.WriteLine("Число нечетное");
// }
// Console.WriteLine("Спасибо за использование нашего софта");
// Console.ReadKey();


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N. (не включая N)

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count < number)
   {
     if(count % 2 == 0)
     {
       Console.Write(count + " ");
     }
     count++;
   }
if(number <= 1)
{
Console.WriteLine("Число " + number + " меньше либо равно 1");
}
Console.ReadKey();
