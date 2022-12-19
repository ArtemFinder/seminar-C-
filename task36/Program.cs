// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0
Random rnd = new Random();
Console.WriteLine("Введите длину массива: ");
int[] arrgh = new int[Convert.ToInt32(Console.ReadLine())];
int sum_nechetnih = 0;
for (int i = 0; i < arrgh.Length; i++)
{
    arrgh[i] = rnd.Next(-99, 100);
    if (i % 2 != 0) sum_nechetnih += arrgh[i];
}
Console.WriteLine($"В массиве [{string.Join(", ", arrgh)}] сумма нечётных позиций в массиве {sum_nechetnih}");