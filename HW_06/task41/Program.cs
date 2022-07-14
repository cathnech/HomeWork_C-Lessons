/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] CreateArr(int size){
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PosCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] > 0 ){
            count++;
        }
    }
    return count;
}

Console.WriteLine("Enter a length of array:");
int res,
    size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter {size} numbers for array:");
Console.WriteLine($"Count of positiv elements = {PosCount( CreateArr(size) )}");