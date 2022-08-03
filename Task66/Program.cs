/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/


int NumberSum(int m, int n)
{
    if (m == n)
    {
        return(m);
    }
    else
    {
        return  (m+NumberSum(m + 1, n));
    }
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Сумма чисел в промежутке от {m} до {n} = {NumberSum(m, n)}");