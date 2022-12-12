// задача 23
Console.Write("Введите до какого числа считать таблицу кубов: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)} ");
