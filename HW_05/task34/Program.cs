/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArr(int size){
    int[] array = new int[size];
    var rmd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(100,1000); 
        
    }
    return array;
}
void PrintArr(int[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}
int CalcCount(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2  == 0){
            count++;
        }
    }
    return count;
}

int size = 4;
int[] arr = CreateArr(size);
PrintArr(arr);
Console.WriteLine($"\ncount {CalcCount(arr)}");