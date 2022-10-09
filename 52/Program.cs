/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

Console.Clear();

Random rnd = new Random();

void FillArray(int[,] coll)
{
    for (int m = 0; m < coll.GetLength(0); m++)
    {
        for (int n = 0; n < coll.GetLength(1); n++)
        {
            coll[m, n] = rnd.Next(0, 10);
        }
    }
}

void PrintArray(int[,] coll)
{
    for (int m = 0; m < coll.GetLength(0); m++)
    {
        for (int n = 0; n < coll.GetLength(1); n++)
        {
            Console.Write($"{coll[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] coll = new int[3, 4];

FillArray(coll);
PrintArray(coll);

Console.Write("Среднее арифметическое каждого столбца: ");

for (int n = 0; n < coll.GetLength(1); n++)
{
    double sum = 0;
    for (int m = 0; m < coll.GetLength(0); m++)
    {
        sum += coll[m, n];
    }

    Console.Write($"{Math.Round(sum / coll.GetLength(0), 1)}; ");
}