/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreateMatrix(int m,int n){
    double[,] array = new double[m,n];
    var rmd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(rmd.NextDouble() * (10+10) - 10 ,2); //Random.NextDouble() * (maxValue - minValue) + minValue  
        } 
    }
    return array;
}
void PrintMatrix(int m, int n, double[,] array){
    
    for (int i = 0; i < m; i++)
    {
        Console.Write("|\t");
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i,j] + "\t");
        } 
        Console.Write("|\n");
    }
}
Console.WriteLine("Enter 2d matrix size:");
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine()); 
double[,] arr = CreateMatrix(m,n);
PrintMatrix(m,n,arr);