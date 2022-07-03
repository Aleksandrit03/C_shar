// Вывод сообщения некоторое кол во раз

void Method1(string msg, int count)
{
int i = 0;
while (i < count)
{
    Console.WriteLine(msg);
    i++;
}
}
Method1("Tekst", 5); //Обращение к функции(методу)
