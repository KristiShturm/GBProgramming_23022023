﻿/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/
Console.Write("Напишите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number > 99 & number < 1000)
{
    int result = (number / 10) % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы написали не трёхзначное число!");
}

