/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
int CalcSum(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
         checked{sum += arr[i];}
    }
    return sum;
}



Console.WriteLine("Enter array's size:");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArr(size);
PrintArr(arr);

try{
    Console.WriteLine($"\n sum {CalcSum(arr)}");
}
catch (System.Exception){
    Console.WriteLine("\nOverflow"); 
}

