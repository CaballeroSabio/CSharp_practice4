/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

Console.Clear();

int[] array = new int[8]; // or int[] array = {5, 9, 3, 5, 4, 7, 7, 1};
int rndNum = new Random().Next(0, 2);
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write("[");
    Console.Write(array[i] + ", ");    
}
Console.Write("]");
Console.WriteLine();

// Вариант второй

int[] array2 = GetRandomArray(12);
WriteArrayToConsole(array);

int[] GetRandomArray(int arrayLength)
{
    Random rnd = new Random();
    int[] arr = new int[arrayLength];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void WriteArrayToConsole(int[] array2)
{
    //Console.Clear();
    Console.Write("[");
    for (int i= 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length -1)
            Console.Write(",");
    }
    Console.WriteLine("]");
}
