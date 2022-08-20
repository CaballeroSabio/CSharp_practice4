/* Задача 34:
 * Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] CreateArrayRndInt (int size, int min, int max)    // создаёт массив случайных чисел
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;    
}

int GetCountEvenNumbers(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            evenCount++;
    }
    return evenCount;
}

void PrintArray (int[] array)   // выводит на печать массив
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInt(10, 0, 1001);
int evenNumbers = GetCountEvenNumbers(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"В массиве  чётных чисел -> {evenNumbers}");

