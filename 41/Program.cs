/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), Convert.ToInt32);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sum = sum + 1;
}
Console.WriteLine($"Чисел больше 0 введено - {sum}");