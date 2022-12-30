// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int line = 0;

void MinLine(int[,] matrix)
{
    double min = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (min < 0) min = sum;
        if (sum < min)
        {
            line = i + 1;
            min = sum;
        }

    }
}

Console.Clear();
int[,] matrix = new int[5, 3];
InputMatrix(matrix);
MinLine(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {line}");