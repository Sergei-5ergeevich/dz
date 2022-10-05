/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.Clear();
Random rnd = new Random();
int[] array = new int[rnd.Next(4, 10)];

void FillArray(int[] coll)
{
    int length = coll.Length;
    int index = 0;
    while (index < length)
    {
        coll[index] = rnd.Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);

int max = array[0];
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine($"Разница между максимальным({max}) и минимальным({min}) элементами массива = {max - min}");