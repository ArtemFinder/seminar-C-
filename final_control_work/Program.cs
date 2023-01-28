//Итоговая проверочная работа.
void printArray(string[] array) //Вывод массива
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} \t");
}

void inputArray(string[] array) //ввод значений массива
{
    for (int i = 0; i < array.Length; i++) array[i] = Console.ReadLine();
}

void copyArray(string[] array, string[] array2) //копирование массива, но только значения не длиннее 3 символов
{
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

Console.Clear();
Console.WriteLine($"Введите длину массива");
string[] array = new string[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine($"Через Enter введите в количестве {array.Length} шт.");
inputArray(array);

Console.WriteLine("В массиве: ");
printArray(array);
Console.WriteLine();
Console.WriteLine("значения не длинее 3 символов:");
string[] array_three = new string[array.Length];
copyArray(array, array_three);
printArray(array_three);