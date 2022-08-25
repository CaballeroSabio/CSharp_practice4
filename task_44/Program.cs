/* Задача 44: 
 * Не используя рекурсию, выведите первые N чисел
 * Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
 * Если N = 5 -> 0 1 1 2 3
 * Если N = 3 -> 0 1 1
 * Если N = 7 -> 0 1 1 2 3 5 8
 */

Console.Clear();

int UserInputInt(string userInputStr)
{
    Console.Write(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num = UserInputInt ("Введите количество чисел");

void Fibonacci(int number)
{
    int f0 = 0;
    int f1 = 1;
    int fn = 0;
    Console.Write($"{f0} {f1}");
    for (int i = 0; i < number-2; i++)
    {
        fn=f0+f1;
        Console.Write($"{fn}");
        f0=f1;
        f1=fn;
    }    
}

Fibonacci(num);
Console.WriteLine();
Console.Write("Press any key");
Console.ReadKey();
