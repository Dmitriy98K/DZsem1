﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
int index = 0;

while (index < numberA)
{
    index++;
    if (index % 2 == 0)
        Console.WriteLine(index);
}






