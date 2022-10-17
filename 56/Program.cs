/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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
int[,] coll = new int[4, 4];
FillArray(coll);

 
int[] sumArray = new int[coll.GetLength(0)]; 
for (int i = 0; i < sumArray.Length; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < coll.GetLength(0); j++)
        {
            sumRow += coll[i, j];
        }
        sumArray[i] = sumRow;
    }

    int minVal = 0; 
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < sumArray[minVal]) minVal = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minVal + 1}");