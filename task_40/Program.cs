/* Задача 40:
 * Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник со сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

/* 1 вариант кода
Console.Clear();

int first = GetUserInput();
int second = GetUserInput();
int third = GetUserInput();

if (IsRectangle(first, second, third))
    Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} может существовать");
else
    Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} не может существовать");

bool IsRectangle(int first, int second, int third)
{
    if (first < second + third && second < first + second && third < first + second) return true;
    return false;
}

int GetUserInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

*/

// Второй вариант кода

Console.Clear();

Console.Write("Введите число1: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число3: ");
int numC = Convert.ToInt32(Console.ReadLine());


bool Triangle(int num1, int num2, int num3)
{
    return num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num2 + num1);
}

bool result = Triangle(numA, numB, numC);
Console.WriteLine(result? "Является тругольником" : "Не может быть треугольником");