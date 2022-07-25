/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNaturalNumbers(int m,int n){
    if (m < n){ 
       return m+SumNaturalNumbers(m+1,n);
    } 
    if (m > n){
        return n+SumNaturalNumbers(m,n+1);
    }
    return n;
}
Console.WriteLine("Enter M & N:"); 
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNaturalNumbers(m,n));