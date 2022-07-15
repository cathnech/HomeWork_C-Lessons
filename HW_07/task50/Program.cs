/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
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
void CheckEl(int m, int n, int[,] array, int mi, int nj){
    if (m<mi || n<nj){
        Console.WriteLine("No such element in the array");    
    }
    else {
        Console.WriteLine(array[mi-1,nj-1]);
    }

}
Console.WriteLine("Enter 2d matrix size:");
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Which element do you want to find:");
int ielem = Convert.ToInt32(Console.ReadLine()),
    jelem = Convert.ToInt32(Console.ReadLine()); 
int[,] arr = CreateMatrix(m,n);
PrintMatrix(m,n,arr);
CheckEl(m,n,arr,ielem,jelem);