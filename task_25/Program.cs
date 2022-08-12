/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(numA, numB));
Console.WriteLine($"Первое число {numA} возводим в натуральную степень, равную второму числу {numB}, и получаем {result}");
Console.WriteLine();

// Извините, я не совсем понял для чего писать цикл, если можно строкой задать метод? Да и как здесь цикл задать, я не пойму

