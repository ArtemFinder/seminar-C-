// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число: ");
string? a = Console.ReadLine();
int x = 0;

for (int i = 0; i < a?.Length; i++) x = x + Convert.ToInt32(Convert.ToString(a[i]));

Console.WriteLine($"В числе {a} сумма цифр = {x}");