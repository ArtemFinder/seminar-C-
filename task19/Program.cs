// задача №19
Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x / 1000 == x - (x / 100 * 100))
    Console.Write($"{x} - это палиндром");
else
    Console.Write($"{x} - это не палиндром");
