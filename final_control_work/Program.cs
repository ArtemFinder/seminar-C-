//Итоговая проверочная работа.
Console.Clear();
void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} \t");
}

void inputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = Console.ReadLine();
}

void copyArray(string[] array, out string[] array2)
{
    array2 = new string[array.Length];
    int index_three = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[index_three] = array[i];
            index_three++;
        }
    }
}

Console.WriteLine($"Введите длину массива");
string[] array = new string[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine($"Введите {array.Length} слов через Enter");
inputArray(array);
Console.WriteLine("В массиве: ");
printArray(array);
Console.WriteLine();
Console.WriteLine("слова не длинее 3 символов:");
string[] array_three = new string[0];
copyArray(array, out array_three);
printArray(array_three);