/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using System;
using static System.Console;
Clear();
Write("Enter number m: ");
int n = int.Parse(ReadLine()!);
Write("Enter number n: ");
int m = int.Parse(ReadLine()!);

WriteLine($"{Accerman(n, m)}");


int Accerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Accerman(n - 1, 1);
    else
      return Accerman(n - 1, Accerman(n, m - 1));
}