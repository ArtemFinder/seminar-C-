// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30
int sum(int a, int b, int x)
{
    if (a < b) return sum(a + 1, b - 1, x + a + b); //а и б двигаются навстречу друг другу что сокращает количество вызов метода примерно в два раза
    else if (a == b) x += a; //чтоб дважды не прибавить одно и тоже число и перейти к концу метода без лишнего вызова
    return x;
}

Console.Clear();
Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите большее число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(m, n, 0));