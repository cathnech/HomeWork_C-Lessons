/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNaturalNumbers(int m,int n){
    if (m == n){ 
        return m;
    }
    return m+SumNaturalNumbers(m+1,n);
}
Console.WriteLine("Enter M & N:"); 
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());
if (m>n){
    Console.WriteLine("Error. M can't be bigger than N");
} 
else
{
    Console.WriteLine(SumNaturalNumbers(m,n));
}