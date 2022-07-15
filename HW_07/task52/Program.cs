/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateMatrix(int m,int n){
    int[,] array = new int[m,n];
    var rmd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rmd.Next(10);
        } 
    }
    return array;
}
void PrintMatrix(int m, int n, int[,] array){
    
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
void ColumnAverage(int m, int n, int[,] array){
    for (int j = 0; j < n; j++)
    {
        double res = 0;
        for (int i = 0; i < m; i++)
        {
            res += array[i,j];
        } 
        Console.WriteLine($"For column {j+1} average is {res/m}");
    }   
     
}
Console.WriteLine("Enter 2d matrix size:");
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine()); 
int[,] arr = CreateMatrix(m,n); //оставила рандомно создаюшийся
PrintMatrix(m,n,arr);
ColumnAverage(m,n,arr);