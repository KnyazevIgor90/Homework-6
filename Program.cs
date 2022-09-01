//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*

int [] CreateArray(int size)
{
    int [] newArray=new int[size];
    for (int i=0; i<size; i++)
    
    {
        Console.WriteLine($"Input {i} number: ");
        newArray [i]=Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i=0;i<array.Length;i ++)
    Console.Write(array [i]+ " ");

    Console.WriteLine();
}

int CountNumbersMoreThen0(int [] array)
{
    int current=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0) current=current+1;
    }
    Console.WriteLine($"Qantity numbers more then 0 is {current} .");
    return current;
}

Console.WriteLine("Input size for array: ");
int a=Convert.ToInt32(Console.ReadLine());

int [] myArray=CreateArray(a);
ShowArray (myArray);
CountNumbersMoreThen0(myArray);

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] Coordinates (double k1, double b1, double k2, double b2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;
}
double ValueRatio (string name)
{
    double ratio;
    Console.Write($"Input number {name}: ");
    ratio = Convert.ToInt32(Console.ReadLine());
    return ratio;
}

double b1 = ValueRatio("b1");
double k1 = ValueRatio("k1");
double b2 = ValueRatio("b2");
double k2 = ValueRatio("k2");

double[] point = Coordinates (k1, b1, k2, b2);

Console.Write($"Coordinates intersection point: ({point[0]}; {point[1]})");