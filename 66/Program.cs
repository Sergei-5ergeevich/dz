/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Clear();

Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

int SumMtoN(int num1, int num2)   
{
    int sum = 0;
    if (num1 == num2)return num1;
    if (num1 < num2)
    {
        while (num1 <= num2 - 1)
        {
            sum = sum + num1;
            num1++;
        }
        if (num1 == num2) sum = sum + num1;
    }

    if (num2 < num1)
    {
        while (num2 <= num1 - 1)
        {
            num2++;
            sum = sum + num2;
        }
        if (num2 == num1) sum = sum + num2;
    }
    return sum;
}
int sum = SumMtoN(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {sum}");