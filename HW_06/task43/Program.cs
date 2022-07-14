/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double[] CreateLine(int linenmb){
    double[] array = new double[2];

    Console.WriteLine($"Enter num 'b' and num 'k' for line number {linenmb}");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double[] IsXY(double[] arr1, double[] arr2)
{
    double b1 = arr1[0], k1 = arr1[1], b2 = arr2[0], k2 = arr2[1];
    double[] xy = new double[2];

    xy[1]= (b1*k2-b2*k1)/(k2 - k1) ;
    xy[0] = xy[1]/k2 - b2/k2 ;
   
    return xy;   
}

void PrintAns(double[] xy){
    
    Console.Write($"The point of intersection of function graphs:\nx = {xy[0]}\ty={xy[1]}");
}


double[] line1 = CreateLine(1); //[b1,k1]
double[] line2 = CreateLine(2); //[b2,k2]
PrintAns(IsXY(line1,line2));