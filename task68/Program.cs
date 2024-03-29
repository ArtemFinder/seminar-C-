﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
int leviAkkerman(int m, int n)
{
    if (m <= 0) return n + 1;
    else if (n == 0) return leviAkkerman(m - 1, 1);
    else return leviAkkerman(m - 1, leviAkkerman(m, n - 1));
}

Console.Clear();
Console.Write("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(leviAkkerman(m, n));