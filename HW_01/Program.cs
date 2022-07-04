/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.WriteLine("Task 2:");
Console.WriteLine("Enter 2 numbers:");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
if ( numA > numB )
    Console.WriteLine($"The min = {numB}.\nThe max = {numA}");
else    
    Console.WriteLine($"The min = {numA}.\nThe max = {numB}");
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Task 4:");
Console.WriteLine("Enter 3 numbers:");
int numC = Convert.ToInt32(Console.ReadLine()),
    numD = Convert.ToInt32(Console.ReadLine()),
    numE = Convert.ToInt32(Console.ReadLine());
int max4;
if ( numC > numD && numC > numE ) 
    max4 = numC;
else {
    if ( numD > numE)
        max4 = numD;
    else
        max4 = numE;
    }

Console.WriteLine($"Max number = {max4}");



/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
Console.WriteLine("Task 6:");
Console.WriteLine("Enter number:");
int numF = Convert.ToInt32(Console.ReadLine());
//bool res = false;
//if ( numF % 2 == 0 )    res = true;

Console.WriteLine($"Result = {numF % 2 == 0}");

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.WriteLine("Task 8:");
Console.WriteLine("Enter number:");
int numG = Convert.ToInt32(Console.ReadLine());
int result = 2;
while ( numG >= result)
{
    Console.WriteLine(result);
    result+=2;
}


/*
Задача 7: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8*/
Console.WriteLine("Task 7:");
Console.WriteLine("Enter a three-digit number:");
int numH = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result = {numH%10}");

