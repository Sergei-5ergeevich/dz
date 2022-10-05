/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.Clear();
Random rnd = new Random();
int [] array = new int [rnd.Next(4,10)];

void FillArray(int[] coll)
{
int length = coll.Length;
int index = 0;
while(index < length) 
    {
        coll[index] = rnd.Next(100,1000);
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
}

FillArray(array);
PrintArray(array);

int even = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0) even++;
}

Console.WriteLine($"Количетсво четных чисел в массиве: {even}");