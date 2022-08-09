/*Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
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

Console.WriteLine();

//второй вариант

//Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int GetNum (int number)
{
    int index = 1;
    int x = 0;
    while (index <= a)
    {
        x = x+1;
        index = index*10;
    }
    return x;
}

int res = GetNum(a);
Console.WriteLine($"Количество цифр в числе =  {res}");
Console.WriteLine();

