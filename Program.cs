//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3   ***4? :)***

/*
double ReadNumbers()
{
    double count = 0;
    for(string? str = string.Empty;;)
    {
        Console.Write("Input number: ");
        str = Console.ReadLine();
        if (String.IsNullOrEmpty(str))
            return count;
        else if (Convert.ToInt32(str) > 0)
            count++;
    }
}
Console.WriteLine($"Count positive numbers: {ReadNumbers()}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
double[] Coordinates (double k1, double b1, double k2, double b2)
{
    double[] coorDot = new double[2];
    coorDot[0] = (b2 - b1) / (k1 - k2);
    coorDot[1] = k1 * coorDot[0] + b1;
    return coorDot;
}
double ValueCoeff (string name)
{
    double coeff;
    Console.Write($"Input number {name}: ");
    coeff = Convert.ToInt32(Console.ReadLine());
    return coeff;
}
double b1 = ValueCoeff("b1");
double k1 = ValueCoeff("k1");
double b2 = ValueCoeff("b2");
double k2 = ValueCoeff("k2");

double[] dot = Coordinates (k1, b1, k2, b2);
Console.Write($"Coordinates intersection point: ({dot[0]}; {dot[1]})");
*/