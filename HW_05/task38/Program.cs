/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] CreateArr(int size){
    int[] array = new int[size];
    var rmd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(); 
        
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
int CalcMinMax(int[] arr){
    int[] mmarray = new int[2]{arr[0],arr[0]};
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > mmarray[1]) { 
            mmarray[1]=arr[i];
        }
        if (arr[i] < mmarray[0]) {
            mmarray[0]=arr[i];
        }
    }
    return mmarray[1]-mmarray[0];
}

int size = 4;
int[] arr = CreateArr(size);
PrintArr(arr);
Console.WriteLine($"\nsum {CalcMinMax(arr)}");
