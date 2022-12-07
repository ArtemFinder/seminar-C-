Console.Write("введите трёхзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вторая цифра: " + x / 10 % 10);
