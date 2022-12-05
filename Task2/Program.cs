Console.Write("Значение а= ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение b= ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение c= ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
    Console.WriteLine("МАХ = " + a);
else if (a < b && b > c)
    Console.WriteLine("МАХ = " + b);
else Console.WriteLine("МАХ = " + c);