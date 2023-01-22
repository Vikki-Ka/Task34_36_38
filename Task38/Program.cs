/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int GetUserData(string massage)
{
    Console.ForegroundColor=ConsoleColor.DarkBlue;
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return UserData;
}

double[] RandomArray(int LenArrey)
{
    double[] Array = new double [LenArrey];
    for (int i = 0; i < LenArrey; i++)
    {
        Array[i] = new Random().NextDouble() * 100;
    }
    return Array;
}

void PrintArray(double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length -1)
        {
            Console.Write(arr[i] + "]");
        }
        else Console.Write(arr[i] + ", ");
    }
 
}

double raznMinMax (double [] arr)
{
    // min
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"min = {min}");
    // max
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max) max = arr[i];
    }
    Console.Write($"max = {max}");
    // razn
    double raznMiMa = max - min;
    return raznMiMa;
}

int UserData = GetUserData("Ввидите длину массива:");
double[] arr = RandomArray(UserData);
PrintArray(arr);
Console.WriteLine();
double raznMiMax = raznMinMax(arr);
Console.WriteLine();
Console.WriteLine($"Разность между максимальнвм числом и минимальным в массиве {raznMiMax}");