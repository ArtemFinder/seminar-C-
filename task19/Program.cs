// задача №19
Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int xl = x / 1000;
int xr = (x % 100 - x % 10) / 10 + x % 10 * 10;
Console.Write($"{xr} - это ");
if (xl == xr)
    Console.Write($"{x} - это палиндром");
else
    Console.Write($"{x} - это не палиндром");
