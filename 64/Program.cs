/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите число N больше нуля: ");
int n = Convert.ToInt32(Console.ReadLine());
AllNums(n); 
int AllNums(int num)
{
    if (num == 1)
    {
        Console.Write($"{num}");
        return num;
    }
    if (num > 0)
    {
        Console.Write($"{num}, ");
        AllNums(num - 1);
    }
    return num;
}

