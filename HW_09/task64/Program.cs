/*
Задача 64: Задайте значения M и N. Напишите программу,
 которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
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