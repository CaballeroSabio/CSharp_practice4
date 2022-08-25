/* Задача 42:
 * Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

/* 1 вариант кода
Console.Clear();
int num = GetUserInput();

System.Console.WriteLine(ConvertToBinary(num));

int GetUserInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

string ConvertToBinary(int num)
{
    string binary = string.Empty;
    
    while (num >= 1)
    {
        binary += num % 2;
        num /= 2;        
    }
    var item = binary.Reverse();
    binary = string.Empty;
    foreach (var i in item)
    {
        binary += i.ToString();
    }
    return binary;
}

void Reverse (int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;

    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}

Console.Write("Press any key");
Console.ReadKey();
*/
// Второй вариант решения
/*
Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string Result(int num1)
{
    string res = "";
    while (num1 > 0)
    {
        res += num1 % 2;
        num1 /= 2;
    }
    return res;
}

void PrintString(string result)
{
    for (int i = result.Length - 1; i >= 0; i--)
    {
        Console.Write(result[i]);
    }
}

string res = Result(num);
PrintString(res);
Console.WriteLine();
Console.Write("Press any key");
Console.ReadKey();
*/
// Решение от преподавателя

void ToBin(int n)
{
    if (n == 0) return;
    ToBin(n / 2);
    Console.Write(n % 2);
}

ToBin(44);


/* В данном методе содержится StringBuilder, которое не видит VisualStudio
 * Но метод якобы преобразует нечто в строку-массив
 * using System.Text; - процедура, которая якобы "заставляет" VisualStudio увидеть stringBuilder

using System.Text;
string WriteArrayAsString(int[] array)
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < array.Length; i++)
    {
        sb.Append(array[i]);
    }
    return sb.ToString();
}
*/