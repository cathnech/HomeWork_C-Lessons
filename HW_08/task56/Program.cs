/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrix(int m,int n){
    int[,] array = new int[m,n];
    var rmd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rmd.Next(10);
        } 
    }
    return array;
}
void PrintMatrix(int[,] array){
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        } 
        Console.Write("|\n");
    }
    Console.Write("\n");
}
int MinSumOfEllements(int[] array){
    int minSumOfEllements = array[0],
        res = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (minSumOfEllements>array[i])
        {
            minSumOfEllements = array[i];
            res = i;
        }
    }
    
    return res+1;
}

int CalculateRowSum(int[,] array){
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           arr[i] += array[i,j];  
        }
    }
    return MinSumOfEllements(arr);
}

Console.WriteLine("Enter 2d matrix size:"); 
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateMatrix(m,n); 
PrintMatrix(arr);
Console.WriteLine($"The number of row with the minimum sum of elements: {CalculateRowSum(arr)}");