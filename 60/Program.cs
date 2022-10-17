/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Clear();
Random rnd = new Random();
void FillArray(int[,,] array)
{
    string[] stringArray = new string[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int stringCount = 0;
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = rnd.Next(1, 100);
                while (stringArray.Contains(Convert.ToString(array[i, j, k])))
                    array[i, j, k] = rnd.Next(1, 100);
                stringArray[stringCount] = Convert.ToString(array[i, j, k]);
                stringCount++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = new int[2, 2, 2];

FillArray(array);
PrintArray(array);