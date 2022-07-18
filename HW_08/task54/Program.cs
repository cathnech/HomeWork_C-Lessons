/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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
int[,] SortRowMatrix(int[,] array){
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int jj = 0; jj < array.GetLength(1); jj++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i,j] > array[i,j + 1])
                {
                    int temp = array[i,j + 1];
                    array[i,j + 1] = array[i,j];
                    array[i,j] = temp;
                }       
            }   
        }
    }
    return array;
}

Console.WriteLine("Enter 2d matrix size:"); 
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateMatrix(m,n); 
PrintMatrix(arr);
int[,] resArr = SortRowMatrix(arr); 
PrintMatrix(resArr);