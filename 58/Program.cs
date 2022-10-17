/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
Console.Clear();
Random rnd = new Random();
void FillArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(1, 10);
            Console.Write($"{coll[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];

FillArray(matrix1);
Console.WriteLine();

FillArray(matrix2);
Console.WriteLine();

int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

for (int x = 0; x < matrix1.GetLength(0); x++)
{
    for (int y = 0; y < matrix1.GetLength(1); y++)
    {
        result[x, y] = matrix1[x,y] * matrix2[x,y];
        Console.Write($"{result[x, y]} ");
    }
    Console.WriteLine();
}
