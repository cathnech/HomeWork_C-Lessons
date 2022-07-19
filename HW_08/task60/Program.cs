/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int RND(int[] arr, int m){ //способ 2
    var rmd = new Random();
    int num = 0;
    bool bl = true;
    while(bl == true)
    {
        num = rmd.Next(10,100);
        bl = false;
        for (int i = 0; i < m; i++)
        {
            bl = (num == arr[i])? true: bl;          
        }
        if (bl == false)
            arr[m] = num;
    }    
    return num;
}
int[,,] CreateMatrix(int m,int n,int l){
    int[,,] array = new int[m,n,l];
    //var rmd = new Random();
    int[] arr = new int[array.Length];
    int count = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i,j,z] = RND(arr,count); //способ 2
                count +=1;
                // foreach (var num in Enumerable.Range(10, 99).OrderBy(x => rmd.Next())) //способ 1 (можно так не повторяющиеся)
                // {
                //array[i,j,z] = num;
                //}
            }
        }
    }

    return array;
}
void PrintMatrix(int[,,] array){
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int z = 0; z < array.GetLength(1); z++)
        {
            Console.Write("|\t");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,z]} ({i},{j},{z}) \t");
            } 
            Console.Write("|\n");
        }
    }
    Console.Write("\n");
}

Console.WriteLine("Enter 3d matrix size:"); 
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine()),
    l = Convert.ToInt32(Console.ReadLine()); 
PrintMatrix(CreateMatrix(m,n,l));
//PrintMatrix(CreateMatrix(2,2,2));