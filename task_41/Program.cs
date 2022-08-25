/* Задача 41:
 * Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 * 0, 7, 8, -2, -2 -> 2
 * -1, -7, 567, 89, 223-> 3
 */

Console.Clear();

Console.Write("Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите четвертое число: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите пятое число: ");
int num5 = Convert.ToInt32(Console.ReadLine());


int CountPosNum(int a, int b, int c, int d, int e)
{
    int count = 0;
    
    if (a > 0) a = 1; else a = 0;
    if (b > 0) b = 1; else b = 0;
    if (c > 0) c = 1; else c = 0;
    if (d > 0) d = 1; else d = 0;
    if (e > 0) e = 1; else e = 0;
    count = a + b + c + d + e;
    return count; // CountPosNum(a,b,c,d,e);
}

int result = CountPosNum(num1, num2, num3, num4, num5);
Console.Write($"Количество чисел больших нуля равно -> {result}");
