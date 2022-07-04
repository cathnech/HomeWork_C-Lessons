/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
//условия пока на уточнение, пока такая реализация

int[] CreateArr(int size){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
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


Console.WriteLine("Enter a length of array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter {size} numbers for array:");

PrintArr( CreateArr(size) );

