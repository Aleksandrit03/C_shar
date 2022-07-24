// Возводит число в квадрат
// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Квадрат числа: {square}");

// // Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// Console.WriteLine("Введите целое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 целое число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int square = number2*number2;
// if (number1 == square)
// {
//     Console.WriteLine($"Число {number1} является квадратом {number2}");
// }
// else
// {
//     Console.WriteLine($"Число {number1} не является квадратом {number2}");
// }

// // Програмама для вывода дня недели
// Console.WriteLine("Введите число от 1 до 7: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x ==1)
// {
//     Console.WriteLine("Понедельник");
// }

// if (x ==2)
// {
//     Console.WriteLine("Вторник");
// }

// if (x ==3)
// {
//     Console.WriteLine("Среда");
// }

// if (x ==4)
// {
//     Console.WriteLine("Четверг");
// }

// if (x ==5)
// {
//     Console.WriteLine("Пятница");
// }

// if (x ==6)
// {
//     Console.WriteLine("Суббота");
// }

// if (x ==7)
// {
//     Console.WriteLine("Воскресенье");
// }

// if (x > 7)
// {
//     Console.WriteLine("Данное число вне диапазона");
// }
// Console.ReadKey();

// Вывод сообщения некоторое кол-во раз
// void Method1(string msg, int count)
// {
// int i = 0;
// while (i < count)
// {
//     Console.WriteLine(msg);
//     i++;
// }
// }
// Method1("Tekst", 5); //Обращение к функции(методу)

// Обращение к методу для вывода времени в консоль
// int Method2()
// {
//     return DateTime.Now.Year;
// }
// int year = Method2();
// Console.WriteLine(year);

// Вывод последовательности несколько раз
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "СасоПавлиашвили");
// Console.WriteLine(res);

// Повторение предъидущей программы с циклом For
// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }

// string res = Method4(10, "СасоПавлиашвили");
// Console.WriteLine(res);

// Написание таблицы умножения
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//      {
//        Console.WriteLine($"{i} * {j} = {i * j}");
//      }
//      Console.WriteLine();
// }

// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".
// string text = "- Шел крокодил, трубку курил, трубка упала и написала, - Шишли мышли сопли вышли";
// // string s = "qwerty"
//          //    012345
// // s[3] // r
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i =0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}"; 
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


// Перестановка чисел в массиве

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, 4, 8, 9, 1, 2, 4, 6, 3 };

        void PrintArray(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]}");
            }
        }
        void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minPosition = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minPosition]) minPosition = j;
                }
                int temporary = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temporary;
            }
        }
        PrintArray(arr);
        SelectionSort(arr);
        Console.WriteLine();
        PrintArray(arr);
    }
}