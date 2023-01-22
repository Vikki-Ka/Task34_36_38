/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int GetUserData(string massage)
{
    Console.ForegroundColor=ConsoleColor.DarkBlue;
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return UserData;
}

int[] RandomArray(int LenArrey, int min, int max)
{
    int[] Array = new int [LenArrey];
    for (int i = 0; i < LenArrey; i++)
    {
        Array[i] = new Random().Next(min, max+1);
    }
    return Array;
}

void PrintArray(int [] arr)
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

int sumNechetVol (int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int UserData = GetUserData("Ввидите длину массива:");
int [] arr = RandomArray(UserData, -10, 10);
PrintArray(arr);
int sumNechetn = sumNechetVol(arr);
System.Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных эллементах в массиве {sumNechetn}");