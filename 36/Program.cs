/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.Clear();
Random rnd = new Random();
int [] array = new int [rnd.Next(4,10)];

void FillArray(int[] coll)
{
int length = coll.Length;
int index = 0;
while(index < length) 
    {
        coll[index] = rnd.Next(-50,51);
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

int sum = 0;
for(int i = 0; i < array.Length; i++)
{
if(i % 2 > 0) sum=sum+array[i];
}

Console.WriteLine($"Сумма элементов стоящих на нечетных позициях в массиве: {sum}");