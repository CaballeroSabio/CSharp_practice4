﻿/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetDigit (int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
        count = count*i;
    }
    return count;
}

int res = GetDigit (n);
Console.WriteLine($"{n} -> {res}");
