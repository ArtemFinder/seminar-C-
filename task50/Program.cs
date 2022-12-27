// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7->такой позиции в массиве нет (пользователь вводит нумерацию с 1)
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindXY(int[,] matrix, int x, int y)
{
    if (matrix.GetLength(0) < y || matrix.GetLength(1) < x)
        Console.Write($"{x}, {y} - такой позиции в массиве нет");
    else Console.Write($"{x}, {y} = {matrix[y - 1, x - 1]}");
}

Console.Clear();
int[,] matrix = new int[4, 5];
InputMatrix(matrix);

Console.Write("Введите какой элемент вывести: ");
int[] xy = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
FindXY(matrix, xy[0], xy[1]);