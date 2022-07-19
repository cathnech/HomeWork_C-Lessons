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