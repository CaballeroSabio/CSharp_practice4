/*Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

Console.Write("Введите число: ");
string? data = Console.ReadLine();


Console.WriteLine($"{data} ->  {GetDigitCount(Convert.ToInt32(data))}");


int GetDigitCount(int num)
{
    int result = 0;
    while(num >= 1)
    {
        num = num/10;
        result++; 
    }
    
    return result;
}


