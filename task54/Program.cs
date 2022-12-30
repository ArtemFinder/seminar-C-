// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 30);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix) //запутался с алгоритмом сортировки...
{
    // int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
    // int key;
    // int a;
    for (int s = 0; s < matrix.GetLength(0); s++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int t = matrix[s, i];
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[s, j] < matrix[s, j + 1])
                {
                    t = matrix[s, j + 1];
                    matrix[s, j + 1] = matrix[s, j];
                    matrix[s, j] = t;
                }
            }
            Console.Write($"{matrix[s, i]} \t");
        }
        // for (int j = 1; j < matrix.GetLength(1); j++) //не осилил другой алгоритм сортировки...
        // {
        //     key = matrix[i, j];
        //     a = j - 1;
        //     while (a >= 0 && matrix[i, a] > key)
        //     {
        //         matrix[i, a + 1] = matrix[i, a];
        //         a = a - 1;
        //     }
        //     matrix[i, a + 1] = key;
        //     Console.Write($"{matrix[i, j]},{key} \t");
        // }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = new int[4, 6];
InputMatrix(matrix);
Console.WriteLine("Отсортированные строки массива: ");
SortMatrix(matrix);