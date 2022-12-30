// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputMatrix(int[,] matrix)
{
    int N = matrix.GetLength(0);
    int M = matrix.GetLength(1);
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    int k = 1, i = 0, j = 0;

    while (k <= N * M)
    {
        matrix[i, j] = k;
        if (i == Ibeg && j < M - Jfin - 1)
            j++;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
            i++;
        else if (i == N - Ifin - 1 && j > Jbeg)
            j--;
        else
            i--;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1)) //круг завершен, увеличение отступа.
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
        k++;
    }
}

Console.Clear();
Console.Write("Введите размеры квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
InputMatrix(matrix);
PrintMatrix(matrix); //чтоб не запутаться решил разделить методы на заполнение и вывод матрицы.