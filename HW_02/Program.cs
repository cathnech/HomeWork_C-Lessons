/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Task 10:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((numA/10)%10);

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.WriteLine("Task 13:");
string? numB = Console.ReadLine();
if ( Convert.ToInt32(numB) < 100 )
    Console.WriteLine("третьей цифры нет");    
else
    Console.WriteLine(numB[2]);

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Task 15:");
int numC = Convert.ToInt32(Console.ReadLine());
if ( numC == 6 || numC == 7)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");