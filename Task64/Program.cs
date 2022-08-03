/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/

void NumberPrint(int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
    }
    else
    {
        Console.Write($"{m}, ");
        NumberPrint(m + 1, n);
    }
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NumberPrint(m, n);
Console.WriteLine();
