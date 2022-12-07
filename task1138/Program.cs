//доп задача второго семинара
Console.Clear();
int n = 0;
int max = 0;
int max2 = 0;
Console.WriteLine("Введите последовательность чисел. 0 для завершения ввода последовательности.");
do
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max)
    {
        max2 = max;
        max = n;
    }
    else if (n > max2) max2 = n;
}
while (n != 0);
Console.WriteLine($"Второй максимум в этой последовательности: {max2}");
