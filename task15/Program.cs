Console.Write("введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0 && x < 6) Console.WriteLine("Пора вjobывать!");
else if (x == 6 || x == 7) Console.WriteLine("ВЫХОДНОЙ!");
else Console.WriteLine("Совсем заработался... Пора в отпуск!"); //На тот случай если забыл сколько дней в неделе :)
