// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16
Console.WriteLine("Введите число А, затем степень В: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int x = 1;
for (int i = 0; i < b; i++) x = x * a;
Console.WriteLine($"{a} в степени {b} = {x}");