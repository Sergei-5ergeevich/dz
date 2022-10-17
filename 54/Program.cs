/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
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
int[,] coll = new int[3, 4];
FillArray(coll);
Console.WriteLine();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            int maxVal = j;
            for (int k = j + 1; k < coll.GetLength(1); k++)
            {
                if (coll[i, k] > coll[i, maxVal]) maxVal = k;
            }
            int tempVal = coll[i, j];
            coll[i, j] = coll[i, maxVal];
            coll[i, maxVal] = tempVal;
            Console.Write($"{coll[i, j]} ");
        }
        Console.WriteLine();
    }

