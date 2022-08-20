/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

/*
double d = 4.32322;
double res = Math.Round(d, 1);\
*/

Console.Clear();

double[] CreateArrayRndDouble (int size, int min, int max) // создаёт массив псевдослучайных вещественных чисел
{
    double[] arr = new double[size];
    Random rnd = new Random();    
    for (int i = 0; i < arr.Length; i++)
    {
        double res = Math.Round(rnd.NextDouble()*10, 1);
        arr[i] = res;        
    }    
    return arr; 
}

void PrintArray (double[] array)   // выводит на печать массив
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + "|");
        else Console.Write(array[i] + "]");
    }
}

double DiffMinMaxValue(double[] arr)
{
    double min = arr.Min();
    double max = arr.Max();
    /*
    for (int i = 0; i < arr.Length; i++)
    {        
        if (arr[i] > max) max = arr[i];        
    }
    for (int i = 0; i < arr.Length; i++)
    {        
        if (arr[i] > max) max = arr[i];        
    } */
    double res1 = max + min;
    return res1;
    
}

double[] array = CreateArrayRndDouble(5, 0, 11);
PrintArray(array);
Console.WriteLine();
double res2 = DiffMinMaxValue(array);
Console.WriteLine($"Сумма максимального и миниального чисел равна -> {Math.Round(res2, 2)}");