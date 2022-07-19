/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateMatrix(int m,int n){//способ 1: рандомно прописанный массив
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
int[,] CreateMatrixHeandler(int m,int n){//способ 2: вручную прописанный массив
    int[,] array = new int[m,n];
    Console.WriteLine("Enter 2d matrix element, by row:");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToInt32(Console.ReadLine());
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
int[,] MultipliedMatrixs(int[,] arr1,int[,] arr2){
    int[,] array = new int[arr1.GetLength(0),arr2.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < arr1.GetLength(1); m++){
                array[i,j] += arr1[i,m]*arr2[m,j];
            }
        } 
    }
    return array;
}
Console.WriteLine("Enter 2d matrix size for first matrix:"); 
int m1 = Convert.ToInt32(Console.ReadLine()),
    n1 = Convert.ToInt32(Console.ReadLine());

int[,] arr1 = CreateMatrix(m1,n1);    //способ 1: рандомно прописанный массив
//int[,] arr1 = CreateMatrixHeandler(m1,n1);  //способ 2: вручную прописанный массив

Console.WriteLine("Enter 2d matrix size for second matrix:"); 
int m2 = Convert.ToInt32(Console.ReadLine()),
    n2 = Convert.ToInt32(Console.ReadLine());

int[,] arr2 = CreateMatrix(m2,n2);       //способ 1: рандомно прописанный массив
//int[,] arr2 = CreateMatrixHeandler(m1,n1);  //способ 2: вручную прописанный массив

// int[,] arr1 = new int[,]{{2,4},{3,2}}; //способ 3: жестко прописанный массив
// int[,] arr2 = new int[,]{{3,4},{3,3}}; //способ 3: жестко прописанный массив
Console.WriteLine("Matrix 1:");
PrintMatrix(arr1);
Console.WriteLine("Matrix 2:");
PrintMatrix(arr2);

if (arr1.GetLength(1) != arr2.GetLength(0)){
    Console.WriteLine("Matrixs can' t be multiplied because of their size"); 
}
else{ 
    PrintMatrix(MultipliedMatrixs(arr1,arr2));
}