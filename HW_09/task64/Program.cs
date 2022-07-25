﻿/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int NaturalNumbers(int n){
    int count = 1;
    Console.Write(n+",");
    if (count == n-1){ 
        return 1;
    }
    return NaturalNumbers(n-count);
}
Console.WriteLine("Enter N:"); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(NaturalNumbers(n));