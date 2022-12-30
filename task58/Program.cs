// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

void MultipMatrix(int[,] matrix, int[,] matrix2) //кое как осилил чт такое матрицы и что такое произведение хотя бы квадратных...
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum = (matrix[i, k] * matrix2[k, j]) + sum;
            }
            Console.Write($"{sum} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = new int[2, 2];
InputMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = new int[2, 2];
InputMatrix(matrix2);
Console.WriteLine("произведение двух квадратных матриц: ");
MultipMatrix(matrix, matrix2);