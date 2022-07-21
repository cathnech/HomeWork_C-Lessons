/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

int AckermannFunction(int m,int n){
    if (m == 0){ 
        return n+1;
    }
    else if ((m > 0) && (n == 0)){ 
        return AckermannFunction(m-1,1);
    }
    else if ((m > 0) && (n > 0)){ 
        return AckermannFunction(m-1,AckermannFunction(m,n-1));
    }
    Console.WriteLine("Error");
    return 0;
}

Console.WriteLine("Enter M & N:"); 
int m = Convert.ToInt32(Console.ReadLine()),
    n = Convert.ToInt32(Console.ReadLine());

if ((m>5) || (n>5) || (m>4&&n==1) || (m>3&&n>1)){
     Console.WriteLine("Error. toooooooo big answer");
} 
 else
{
    Console.WriteLine($"For M = {m} & N = {n}: " + AckermannFunction(m, n));
}
Console.WriteLine("Tests:");
Console.WriteLine("For M = 0 & N = 0: " + AckermannFunction(0, 0)); // 1
Console.WriteLine("For M = 2 & N = 1: " + AckermannFunction(2, 1)); // 5
Console.WriteLine("For M = 2 & N = 3: " + AckermannFunction(2, 3)); // 9