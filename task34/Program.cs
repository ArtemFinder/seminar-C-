// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Random rnd = new Random();
Console.WriteLine("Введите длину массива: ");
int[] arrgh = new int[Convert.ToInt32(Console.ReadLine())];
int chetko = 0;
for (int i = 0; i < arrgh.Length; i++)
{
    arrgh[i] = rnd.Next(100, 1000);
    if (arrgh[i] % 2 == 0) chetko++;
}
Console.WriteLine($"В массиве [{string.Join(", ", arrgh)}] количество чётных чисел {chetko}");