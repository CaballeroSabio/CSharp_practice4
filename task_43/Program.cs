/*Задача 43: 
 *Напишите программу, которая найдёт точку пересечения двух прямых,
 *заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 *значения b1, k1, b2 и k2 задаются пользователем.
 *b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
 */


Console.Clear();

Console.Write("Введите первое число: ");
double a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
double a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертое число: ");
double c2 = Convert.ToInt32(Console.ReadLine());

double IntersectionPointX(double a1, double a2, double c1, double c2)
{
    double x = (a2 - a1)/(c1 - c2);
    return Math.Round(x, 1);
}

double resX = IntersectionPointX(a1, a2, c1, c2);

double IntersectionPointY(double c1, double a1)
{
    double y = c1*resX + a1;
    return Math.Round(y, 1);
}

double resY = IntersectionPointY(c1, a1);
Console.WriteLine($"({resX}|{resY})");