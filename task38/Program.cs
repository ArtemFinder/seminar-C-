// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Random rnd = new Random();
double[] arrgh = new double[10];
double max = 0;
double min = 100;
for (int i = 0; i < arrgh.Length; i++)
{
    arrgh[i] = rnd.Next(0, 100); //в задании вещественные числа, а в примере положительные, целлые, двухзначные, потому от нуля до 100.
    if (arrgh[i] >= max) max = arrgh[i];
    if (arrgh[i] <= min) min = arrgh[i];
}
Console.WriteLine($"В массиве [{string.Join(", ", arrgh)}] разница между {max} и {min} = {max - min}");