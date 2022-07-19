/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
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
int[] FindFirstMinElement(int[,] arr){  
    int min = arr[0,0];
    int[] coordinats = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j]<min)
            {
                min = arr[i,j];
                coordinats = new int[]{i,j};
            }
        } 
    }
    return coordinats;
}
int[,] DeleteColRow(int[,] arr){
    int[,] array = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int[] coordinats = FindFirstMinElement(arr);

    for (int i = 0,ii = 0; i < array.GetLength(0); i++, ii++)
    {
        if (i == coordinats[0]){ii++;}
        for (int j = 0,jj = 0; j < array.GetLength(1); j++,jj++)
        {
            if (j == coordinats[1]){jj++;}
            array[i,j] = arr[ii,jj];
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
Console.WriteLine("Enter 2d matrix size:"); 
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateMatrix(m,n); 
PrintMatrix(arr);
int[,] resArr = DeleteColRow(arr); //удаление по первому наименьшему элементу массива
PrintMatrix(resArr);