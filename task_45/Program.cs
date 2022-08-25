/* Задача 45:
 * Напишите программу, которая будет создавать
 * копию заданного массива с помощью поэлементного
 * копирования.
 */

using System.Text;

Console.Clear();

int[] array = CreateArrayRandomInt(8,1,9);
int[] newArray = Copy(array);

Console.WriteLine("Исходный массив: " + WriteArrayAsString(array));
Console.WriteLine("Скопированный массив " + WriteArrayAsString(newArray));
array[0] = 4;
Console.WriteLine("Изменили первый элемент исходного массива: " + WriteArrayAsString(array));
Console.WriteLine("Скопированный массив без изменений: " + WriteArrayAsString(newArray));

int[] Copy(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

int[] CreateArrayRandomInt (int arrayLength, int minValue, int maxValue)
{
    int[] arr = new int[arrayLength];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

string WriteArrayAsString(int[] array)
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < array.Length; i++)
    {
        sb.Append(array[i]);
    }
    return sb.ToString();
}

Console.WriteLine();
Console.Write("Press any key");
Console.ReadKey();
