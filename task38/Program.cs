// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Random rnd = new Random();
double[] arrgh = new double[10];
double a = -100;
double b = 100;
for (int i = 0; i < arrgh.Length; i++)
{
    //arrgh[i] = rnd.Next(0, 100); //в задании вещественные числа, а в примере положительные, целлые, двухзначные, потому этот вариант от 0 до 100.
    arrgh[i] = Math.Round(rnd.NextDouble() * 200 - 100, 2); //[-100, 100]
    if (arrgh[i] > a) a = arrgh[i];
    if (arrgh[i] < b) b = arrgh[i];
}
Console.WriteLine($"В массиве [{string.Join(", ", arrgh)}] разница между {a} и {b} = {Math.Round(a - b, 2)}");