/* Задача 36:
 * Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0
*/

int[] CreateArrayRndInt (int size, int min, int max) // создаёт массив случайных чисел
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;    
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

int GetSumElemOddPos(int[] array)
{
    //int oddPos = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1) sum = sum + array[i];
        //sum = sum + oddPos;
    }
    return sum;  
}

int[] array = CreateArrayRndInt(5, 0, 11);
PrintArray(array);
Console.WriteLine();
int oddSum = GetSumElemOddPos(array);
Console.WriteLine($"В массиве сумма элементов, стоящих на нечётных позициях -> {oddSum}");
