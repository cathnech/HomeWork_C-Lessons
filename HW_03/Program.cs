/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine("Task 19:");
int numA = Convert.ToInt32(Console.ReadLine());//можно еще строку реверснуть и сравнить
int numAA = numA;
int reversNum = 0;
while ( numAA!=0 )
{
    reversNum += numAA%10; 
    numAA/=10;
    if (numAA >0) reversNum*=10;
}
if (reversNum == numA) 
    Console.WriteLine("да");
else
    Console.WriteLine("нет");

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Task 21:");
Console.WriteLine("Enter x,y,z for A:");
double xA = Convert.ToDouble(Console.ReadLine()),
    yA = Convert.ToDouble(Console.ReadLine()),
    zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x,y,z for B:");
double xB = Convert.ToDouble(Console.ReadLine()),
    yB = Convert.ToDouble(Console.ReadLine()),
    zB = Convert.ToDouble(Console.ReadLine());
double res = Math.Sqrt(Math.Pow(xB - xA, 2)+Math.Pow(yB - yA, 2)+Math.Pow(zB - zA, 2));
Console.WriteLine(Math.Round(res, 2));


/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Task 23:");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N+1; i++)
{
    Console.WriteLine(i*i*i);   
}