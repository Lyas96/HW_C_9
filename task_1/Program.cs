/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1 */

using System;
using static System.Console;
Clear();
Write("Enter number N: ");
int num = int.Parse(ReadLine()!);


Nums1_N(num);
Write(Nums1_N(num));

string Nums1_N(int num)
{
  if (num == 1)
  {
    return num.ToString();
  }
  return num + ", " + Nums1_N(--num);
}