//Итоговая проверочная работа.
void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} \t");
}

void inputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = Console.ReadLine();
}

Console.WriteLine($"Введите длину массива");
string[] array = new string[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine($"Введите {array.Length} слов через Enter");
inputArray(array);
Console.WriteLine("Массив где слова не длинее 3 символов");
printArray(array);