// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int s = 0;
void summ_array(int[] array, out int d) //хотелось попробовать процедуру, хотя здесь в ней не вижу необходимости.
{
    d = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] > 0) d++;
}

Console.WriteLine("Введите несколько чисел через запятую: ");
int[] a = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();
summ_array(a, out s);
Console.WriteLine($"Введено {s} числа больше 0.");