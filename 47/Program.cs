/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.Clear();

Random rnd = new Random();

void FillArray(double[,] coll)
{
    for (int m = 0; m < coll.GetLength(0); m++)
    {
        for(int n = 0; n < coll.GetLength(1); n++)
        {
            coll[m, n] =  Convert.ToDouble(rnd.Next(-10, 10)) + rnd.NextDouble();
        }
    }
}

void PrintArray(double[,] coll) 
{
    for(int m = 0; m < coll.GetLength(0); m++)
    {
        for(int n = 0; n < coll.GetLength(1); n++)
        {
            Console.Write($"{Math.Round(coll[m, n],2)} ");
        }
    Console.WriteLine();
    }
}


double[,] collect = new double[3,4];


FillArray(collect);
PrintArray(collect);