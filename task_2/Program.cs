/*  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;
using static System.Console;
Clear();
Write("Enter number N: ");
int num1 = int.Parse(ReadLine()!);
Write("Enter number M: ");
int num2 = int.Parse(ReadLine()!);


Nums1_N(num1, num2);
Write(Nums1_N(num1, num2));

int Nums1_N(int num1, int num2)
{
  if (num1 == num2)
  {
    return num1;
  }
  return num1 + Nums1_N(++num1, num2);
}