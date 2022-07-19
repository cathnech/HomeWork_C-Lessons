/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateMatrix(int n){
    int[,] array = new int[n,n];
    int num = 1,
        b = 0,
        a = n-1;
    while (num <= n*n)
    {
        for (int j = b; j <= a; j++)
        {
            array[b,j] = num;
            num++;
        } 
    
        for (int i = b+1; i <= a; i++)
        {
            array[i,a] = num;
            num++;
        }
        a--;   
        for (int j = a; j >= b; j--)
        {
            array[a+1,j] = num;
            num++;
        } 
        
        for (int i = a; i > b; i--)
        {
            array[i,b] = num;
            num++;
        }
        b++;
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

Console.WriteLine("Enter 2d matrix size:"); 
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateMatrix(n); 
PrintMatrix(arr);