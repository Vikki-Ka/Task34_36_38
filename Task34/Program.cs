/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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

int getChetNumber (int [] arr)
{
    int chetVal = 0;    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 )
        {
            chetVal++;
        }
    }
    return chetVal;
}

int userData = GetUserData("Ввидите длину массива");
int [] arr = RandomArray(userData, 100, 999);
PrintArray(arr);
int chet = getChetNumber(arr);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Количество четных чисел в массиве {chet}");
Console.ResetColor();