/*
Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника.
*/

int[,] CreateMatrix(int n){
    int[,] array = new int[n,n];
    array[0,0] = 1;
    array[n-1,n-1] = 1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i,0] = 1;
        for (int j = 1; j < array.GetLength(1)-1; j++)
        {
            array[i,j] = array[i-1,j]+array[i-1,j-1];
        } 
    }
    return array;
}

void PrintMatrix(int[,] array){
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]!=0) Console.Write(array[i,j] + "\t");
        } 
        Console.Write("\n");
    }
    Console.Write("\n");
}

Console.WriteLine("Enter number of rows N :"); 
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateMatrix(n); 
PrintMatrix(arr);