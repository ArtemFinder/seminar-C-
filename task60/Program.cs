// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)
void InputMatrix(int[,,] matrix)
{
    int i = 10;
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        Console.WriteLine($"глубина Z {z}"); // чтоб не запутаться в объеме и нормально видеть где другой слой глубины
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                matrix[x, y, z] = i;
                i++;
                Console.Write($"{matrix[x, y, z]}({x},{y},{z}) \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размеры 3D матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 90)
{
    Console.Write("Введен слишком большой размер 3D матрицы. Укажите размеры 3D матрицы поменьше: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);