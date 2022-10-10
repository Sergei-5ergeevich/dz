/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.Clear();

Random rnd = new Random();

void FillArray(int[,] coll)
{
    for (int m = 0; m < coll.GetLength(0); m++)
    {
        for (int n = 0; n < coll.GetLength(1); n++)
        {
            coll[m, n] = rnd.Next(-10, 10);
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

Console.Write("Введите индекс строки: ");
int indexrow = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Введите индекс столбца: ");
int indexcolumn = Convert.ToInt32(Console.ReadLine())-1;

if (indexrow <= coll.GetLength(0) && indexcolumn <= coll.GetLength(1))
{
    Console.WriteLine(coll[indexrow, indexcolumn]);
}
else
{
    Console.WriteLine("Такой позиции в массиве нет");
}

