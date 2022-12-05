Console.Write("Список всех чётных чисел до числа N = ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i < n)
{
    i++;
    if (i % 2 == 0)
        Console.Write(i + ", ");
}