Console.Write("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int x3 = 0;
if (x < 100) Console.Write("Третьей цифры нет.");
else
{
    x3 = x;
    while (x3 > 999) x3 = x3 / 10;
}
Console.WriteLine("Третья цифра: " + x3 % 10);