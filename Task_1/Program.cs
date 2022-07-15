/*
    Задача 41: 
    Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

Console.Write("Сколько вы хотели написать количество чисел?: ");
int n = Convert.ToInt32(Console.ReadLine()),
    x = 0;
int[] Num = new int[n];

for (int i = 0; i <= n - 1; i++)
{
    Console.Write("введите число ", i + 1, ": ");
    Num[i] = Convert.ToInt32(Console.ReadLine());
    if (Num[i] > 0)
        x++;
}


Console.WriteLine("[ " + string.Join(", ", Num) + " ]");

Console.Write("Количество положительных чисел: ");
Console.WriteLine(x);
