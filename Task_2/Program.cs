/*
    Задача 43: 
    Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

Console.Write("[ ");
Console.Write(x);
Console.Write(" ; ");
Console.Write(y);
Console.Write(" ]");











/*
double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

Console.Write(x);
Console.Write(y);




double y1 = k1*x+b1;
double y2 = k2*x+b1;

Console.Write(y1);
Console.Write(y2);


double x = (b2 - b1) / (k1 - k2);
Console.Write(x);
double y = b1*x+b2;
Console.Write(y);


*/