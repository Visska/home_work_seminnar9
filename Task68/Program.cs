/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

int AckkermanFunction(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  } 
  else if (n == 0)
  {
    return AckkermanFunction(m - 1, 1);
  }
  else 
  {
    return AckkermanFunction(m - 1, AckkermanFunction(m, n - 1));
  }
}


Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int function = AckkermanFunction(m, n);
Console.Write($"Функция Аккермана = {function}");