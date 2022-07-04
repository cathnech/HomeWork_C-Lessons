/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int PowerFunction(int a, int b){
    int pwr = a;
    for (int i = 0; i < b-1; i++)
    { 
        checked{pwr *= a;}
    }
    return pwr;
}

Console.WriteLine("Enter 2 numbers");
int a = Convert.ToInt32(Console.ReadLine()),
    b = Convert.ToInt32(Console.ReadLine());

try
{
    //int res = PowerFunction(a,b); 
    Console.WriteLine(PowerFunction(a,b));
}
catch (System.Exception)
{
    Console.WriteLine("Overflow"); 
}
