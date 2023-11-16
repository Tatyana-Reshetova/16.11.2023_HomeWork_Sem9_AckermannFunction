// **Задача 1:**Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке
//  от  N до M.

// M = 1; N = 5. -> "5, 4, 3, 2, 1"

// M = 4; N = 8. -> "8, 7, 6, 5, 4"

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(n, m));

string PrintNumbers(int end, int start)
{
    if (end == start)
        return end.ToString();
    return (end + " " + PrintNumbers(end - 1, start));
}