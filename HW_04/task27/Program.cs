/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumFunction(int a){
    int sum = 0;
    if (a<0) a = -a;
    while (a>0)
    { 
        sum +=  a%10;
        a   /=  10;
    }
    return sum;
}

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(SumFunction(num));
