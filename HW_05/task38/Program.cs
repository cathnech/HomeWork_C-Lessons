/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] CreateArr(int size){
    double[] array = new double[size];
    var rmd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rmd.NextDouble(),3); 
        
    }
    return array;
}
void PrintArr(double[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}
double CalcMinMax(double[] arr){
    double[] mmarray = new double[2]{arr[0],arr[0]};
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > mmarray[1]) { 
            mmarray[1]=arr[i];
        }
        if (arr[i] < mmarray[0]) {
            mmarray[0]=arr[i];
        }
    }
    return Math.Round(mmarray[1]-mmarray[0],3);
}

Console.WriteLine("Enter array's size:");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = CreateArr(size);
PrintArr(arr);
Console.WriteLine($"\nsum {CalcMinMax(arr)}");
